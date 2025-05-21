Imports MySql.Data.MySqlClient

Public Class RegisterFrm
    ' MySQL connection string
    Private ReadOnly connectionString As String = "Server=localhost;Database=CollegeEnrollmentDB;Uid=root;Pwd=;"
    Private ReadOnly connection As New MySqlConnection(connectionString)

    Private Sub RegisterFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Default enrollment date
        EnrDateTxt.Text = DateTime.Now.ToString("yyyy-MM-dd")

        ' Populate combo boxes
        ModeCMB.Items.AddRange(New String() {"F2F", "OC", "Hybrid"})
        Sub1Cmb.Items.AddRange(GetSubjects())
        Sub2Cmb.Items.AddRange(GetSubjects())
        Sub3Cmb.Items.AddRange(GetSubjects())
        Sub4Cmb.Items.AddRange(GetSubjects())
        Sub5Cmb.Items.AddRange(GetSubjects())
    End Sub

    Private Function GetSubjects() As String()
        Return New String() {"Math 101", "Science 101", "Programming 101", "History 101"}
    End Function

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        If String.IsNullOrWhiteSpace(studentNoTxt.Text) OrElse
           String.IsNullOrWhiteSpace(NameTxt.Text) OrElse
           String.IsNullOrWhiteSpace(CourseTxt.Text) Then
            MessageBox.Show("Please fill in all required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            connection.Open()
            Dim query As String = "
                INSERT INTO Enrollees (
                    StudentNo, FullName, Gender, Age, Address, Contact, EmergencyContact, Email,
                    Course, YearLevel, EnrollmentStatus, PreviousSchool, EnrollmentDate, AcademicYear,
                    ModeOfLearning, PaymentStatus, Subject1, Subject2, Subject3, Subject4, Subject5
                ) VALUES (
                    @StudentNo, @FullName, @Gender, @Age, @Address, @Contact, @EmergencyContact, @Email,
                    @Course, @YearLevel, @EnrollmentStatus, @PreviousSchool, @EnrollmentDate, @AcademicYear,
                    @ModeOfLearning, @PaymentStatus, @Subject1, @Subject2, @Subject3, @Subject4, @Subject5
                )"

            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@StudentNo", studentNoTxt.Text)
                cmd.Parameters.AddWithValue("@FullName", NameTxt.Text)
                cmd.Parameters.AddWithValue("@Gender", GenderTxt.Text)
                cmd.Parameters.AddWithValue("@Age", Integer.Parse(AgeTxt.Text))
                cmd.Parameters.AddWithValue("@Address", AddressTxt.Text)
                cmd.Parameters.AddWithValue("@Contact", ContactTxt.Text)
                cmd.Parameters.AddWithValue("@EmergencyContact", EmTxt.Text)
                cmd.Parameters.AddWithValue("@Email", EmailTxt.Text)

                cmd.Parameters.AddWithValue("@Course", CourseTxt.Text)
                cmd.Parameters.AddWithValue("@YearLevel", YrlvlTxt.Text)
                cmd.Parameters.AddWithValue("@EnrollmentStatus", EnrStatusTxt.Text)
                cmd.Parameters.AddWithValue("@PreviousSchool", PrvSchlTxt.Text)

                cmd.Parameters.AddWithValue("@EnrollmentDate", DateTime.Parse(EnrDateTxt.Text))
                cmd.Parameters.AddWithValue("@AcademicYear", AcadTxt.Text)
                cmd.Parameters.AddWithValue("@ModeOfLearning", ModeCMB.Text)
                cmd.Parameters.AddWithValue("@PaymentStatus", PaymentTxt.Text)

                cmd.Parameters.AddWithValue("@Subject1", Sub1Cmb.Text)
                cmd.Parameters.AddWithValue("@Subject2", Sub2Cmb.Text)
                cmd.Parameters.AddWithValue("@Subject3", Sub3Cmb.Text)
                cmd.Parameters.AddWithValue("@Subject4", Sub4Cmb.Text)
                cmd.Parameters.AddWithValue("@Subject5", Sub5Cmb.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearForm()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        ' Clear all input fields
        studentNoTxt.Clear()
        NameTxt.Clear()
        GenderTxt.Clear()
        AgeTxt.Clear()
        AddressTxt.Clear()
        ContactTxt.Clear()
        EmTxt.Clear()
        EmailTxt.Clear()

        CourseTxt.Clear()
        YrlvlTxt.Clear()
        EnrStatusTxt.Clear()
        PrvSchlTxt.Clear()

        EnrDateTxt.Text = DateTime.Now.ToString("yyyy-MM-dd")
        AcadTxt.Clear()
        ModeCMB.SelectedIndex = -1
        PaymentTxt.Clear()

        Sub1Cmb.SelectedIndex = -1
        Sub2Cmb.SelectedIndex = -1
        Sub3Cmb.SelectedIndex = -1
        Sub4Cmb.SelectedIndex = -1
        Sub5Cmb.SelectedIndex = -1

        studentNoTxt.Focus()
    End Sub
End Class
