Imports System.Data

Partial Class GridViewCss_Default
    Inherits System.Web.UI.Page

    Private Sub BindData()
        Dim dt As New DataTable()
        dt.Columns.Add("EmpId", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Address", GetType(String))
        dt.Columns.Add("Date", GetType(DateTime))
        '
        ' Here we add five DataRows.
        '
        dt.Rows.Add(25, "José", "México", DateTime.Now)
        dt.Rows.Add(50, "Fransua Meme", "Francia", DateTime.Now)
        dt.Rows.Add(10, "Ruben", "España", DateTime.Now)
        dt.Rows.Add(21, "Aditya", "Italia", DateTime.Now)
        dt.Rows.Add(100, "Jhon", "Inglaterra", DateTime.Now)

        dt.Rows.Add(101, "ABC", "Delhi", DateTime.Now)
        dt.Rows.Add(102, "XYZ", "Noida", DateTime.Now)
        dt.Rows.Add(103, "BBC", "Delhi", DateTime.Now)
        dt.Rows.Add(104, "CIA", "Banglore", DateTime.Now)
        dt.Rows.Add(105, "KBC", "Delhi", DateTime.Now)
        dt.Rows.Add(106, "Jack", "Noida", DateTime.Now)
        dt.Rows.Add(107, "Jhon", "Gurgaon", DateTime.Now)
        dt.Rows.Add(108, "Mali", "Gurgaon", DateTime.Now)
        dt.Rows.Add(109, "Sara", "Noida", DateTime.Now)


        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub

    Protected Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        GridView1.PageIndex = e.NewPageIndex
        BindData()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        BindData()
    End Sub
End Class
