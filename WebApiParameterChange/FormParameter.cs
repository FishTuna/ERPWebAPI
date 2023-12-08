using Core.Entities.Concrete;

namespace WebApiParameterChange
{
    public partial class FormParameter : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FormParameter()
        {
            InitializeComponent();

        }

        private void accordionControlChkDbCon_Click(object sender, EventArgs e)
        {

            navigationFrame1.SelectedPage = navPageCheckDbCon;
            chkDContentLabelDbName.Text = $":{DbConnectionInfo.DatabaseName}";
            chkDContentLabelDbType.Text = $":{DbConnectionInfo.DbType}";
            chkDContentLabelEncrypt.Text = $":{DbConnectionInfo.Encrypt}";
            chkDContentLabelPassword.Text = $":{DbConnectionInfo.Password}";
            chkDContentLabelServer.Text = $":{DbConnectionInfo.Server}";
            chkDContentLabelUser.Text = $":{DbConnectionInfo.User}";

        }

        private void accordionControlElementChangeDbInfos_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navPageChangeDbCon;
        }

        private void accordionControlaccordionControlChkApiCon_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navPageCheckApiCon;
        }

        private void accordionControlElementChangeApiInfos_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navPageChangeApiCon;
        }
    }
}
