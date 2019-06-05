<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" ValidateRequest="false" %>
<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Richtextbox Sample</title>
    <script type="text/javascript">
        function validate() {
            var doc = document.getElementById('FreeTextBox1');
            if (doc.value.length == 0) {
                alert('Please Enter data in Richtextbox');
                return false;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <ftb:freetextbox id="FreeTextBox1" runat="server">
</ftb:freetextbox>
                    </td>
                    <td valign="top">
                        <asp:GridView runat="server" ID="gvdetails" AutoGenerateColumns="false">
                            <Columns>
                                <asp:TemplateField HeaderText="RichtextBoxData">
                                    <ItemTemplate>
                                        <asp:Label ID="lbltxt" runat="server" Text='<%#Bind("RichtextData") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnSubmit" runat="server" OnClientClick="return validate()"
            Text="Submit" OnClick="btnSubmit_Click" /><br />
        <asp:Label ID="lbltxt" runat="server" />
    </form>
</body>
</html>
