Public Class EmployeeSignUpForm
    Private Sub EmployeeSignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EmployeeSignUpForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Redirect to the EmployeeLogInForm when this form is closed
        Dim loginForm As New EmployeeLogInForm()
        loginForm.Show()
    End Sub

End Class