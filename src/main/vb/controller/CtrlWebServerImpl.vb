Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class CtrlWebServerImpl
    : Inherits AbstractCtrl

    Property documentRoot As String = ""
    Private listener As HttpListener

    Public Overrides Sub validate()
        'Do nothing.
    End Sub

    Public Overrides Sub open()
        ServerStart()
    End Sub

    Public Overrides Sub execute()
        Dim run As Boolean = True
        While run

            Try
                ServerWait()
            Catch bgwcEx As BackGroundWorkerCancelException
                run = False
            Catch ex As Exception
                Console.WriteLine(ex.Message & vbCrLf &
                                  ex.StackTrace)
            End Try
        End While

    End Sub

    Public Overrides Sub close()
        ctrlProgressObject.changeProgressText("HTTPサーバのクローズ中。")
        listener.Close()
    End Sub



    Sub ServerStart()
        Dim prefix As String = "http://*/" ' 受け付けるURL

        listener = New HttpListener()
        listener.Prefixes.Add(prefix) ' プレフィックスの登録

        listener.Start()
        System.Diagnostics.Process.Start("http://localhost:80/index.html")
    End Sub


    Sub ServerWait()
        While (True)
            Dim context As HttpListenerContext = listener.GetContext()
            Dim req As HttpListenerRequest = context.Request
            Dim res As HttpListenerResponse = context.Response
            checkCancellation()


            'Console.WriteLine(req.RawUrl)

            ' リクエストされたURLからファイルのパスを求める
            Dim path As String = documentRoot & req.RawUrl.Replace("/", "\\")

            ' ファイルが存在すればレスポンス・ストリームに書き出す
            If File.Exists(path) Then
                Dim content() As Byte = File.ReadAllBytes(path)
                res.OutputStream.Write(content, 0, content.Length)
            End If

            res.Close()
        End While
    End Sub

    Public Sub sendCloseMessage()
        Dim request As WebRequest = WebRequest.Create("http://localhost/index.html")
        request.Method = "POST"
        Dim postData As String = "For Server closing message."
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
        request.ContentType = "application/x-www-form-urlencoded"
        request.ContentLength = byteArray.Length
        Dim dataStream As Stream = request.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close()
    End Sub


    Public Overrides Sub cancelled()
        MyBase.cancelled()
        ctrlProgressObject.changeProgressText("DocumentRootを設定してください。")
    End Sub

    Public Overrides Sub completed()
        ctrlProgressObject.changeProgressText("DocumentRootを設定してください。")
    End Sub
End Class
