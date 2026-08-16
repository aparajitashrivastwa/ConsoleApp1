<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student-detail.aspx.cs" Inherits="WebApplication1.student_detail" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registration</title>
    <style type="text/css">
        .error-msg {
            color: red;
            font-size: 13px;
            padding-left: 10px;
        }
        td {
            padding: 6px 8px;
            vertical-align: middle;
        }
        .align-top {
            vertical-align: top;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Student Details Form</h2>
            <table>
                <tr>
                    <td>Student ID:</td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td><asp:Label ID="lblErrorId" runat="server" CssClass="error-msg"></asp:Label></td>
                </tr>
                <tr>
                    <td>First Name:</td>
                    <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    <td><asp:Label ID="lblErrorFirstName" runat="server" CssClass="error-msg"></asp:Label></td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                    <td><asp:Label ID="lblErrorLastName" runat="server" CssClass="error-msg"></asp:Label></td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                    <td><asp:Label ID="lblErrorEmail" runat="server" CssClass="error-msg"></asp:Label></td>
                </tr>
                <tr>
                    <td class="align-top">Department:</td>
                    <td>
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Computer Science and Engineering" GroupName="Department" /><br/>
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="Electrical Engineering" GroupName="Department" /><br/>
                        <asp:RadioButton ID="RadioButton3" runat="server" Text="Mechanical Engineering" GroupName="Department" /><br/>
                        <asp:RadioButton ID="RadioButton4" runat="server" Text="Civil Engineering" GroupName="Department" />
                    </td>
                    <td class="align-top"><asp:Label ID="lblErrorDept" runat="server" CssClass="error-msg"></asp:Label></td>
                </tr>
                <tr>
                    <td class="align-top">Gender:</td>
                    <td>
                        <asp:RadioButton ID="RadioButton5" runat="server" Text="Male" GroupName="Gender" /><br/>
                        <asp:RadioButton ID="RadioButton6" runat="server" Text="Female" GroupName="Gender" />
                    </td>
                    <td class="align-top"><asp:Label ID="lblErrorGender" runat="server" CssClass="error-msg"></asp:Label></td>
                </tr>
                <tr>
                    <td class="align-top">Skills:</td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="C#" /><br/>
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="C++" /><br/>
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="Python" /><br/>
                        <asp:CheckBox ID="CheckBox4" runat="server" Text="Java" />
                    </td>
                    <td class="align-top"><asp:Label ID="lblErrorSkills" runat="server" CssClass="error-msg"></asp:Label></td>
                </tr>
                <tr>
                    <td class="align-top">Address:</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Columns="25" Rows="4" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td class="align-top"><asp:Label ID="lblErrorAddress" runat="server" CssClass="error-msg"></asp:Label></td>
                </tr>
                <tr>
                    <td>Terms & Conditions:</td>
                    <td>
                        <asp:CheckBox ID="CheckBox5" runat="server" Text="I agree to the terms and conditions" />
                    </td>
                    <td><asp:Label ID="lblErrorTerms" runat="server" CssClass="error-msg"></asp:Label></td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Submit" Width="84px" OnClick="btnSubmit_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Clear" Width="72px" OnClick="btnClear_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <br />
                        <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>