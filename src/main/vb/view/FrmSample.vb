

Public Class FrmWebStart

    Private ctrl As New CtrlWebServerImpl()

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = getToolsName()
        TSSBtnStop.Image = SystemIcons.Hand.ToBitmap
        ctrl.ctrlProgressObject = New ProgressFormControl(TSSLabel, TSProgressBar)
        TSSLabel.Text = "DocumentRoot��ݒ肵�Ă��������B"
    End Sub

    Private Sub StopButton_ButtonClick(sender As Object, e As EventArgs) Handles TSSBtnStop.ButtonClick
        ctrl.stopWorker()
        TSSLabel.Text = "�I���ҋ@���B�A�N�Z�X�����ƏI�����܂��B"
        ctrl.sendCloseMessage()
    End Sub


    Private Sub BtnServerStart_Click(sender As Object, e As EventArgs) Handles BtnServerStart.Click
        ctrl.documentRoot = TxtDocumentRoot.Text
        TSSLabel.Text = "�T�[�o�[�N�����ł��B"
        ctrl.startWorker()
    End Sub

End Class
