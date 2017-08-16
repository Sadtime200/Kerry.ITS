using System;
using Kerry.ITS.JobFactoryServiceReference;

namespace Kerry.ITS
{
    public partial class UpdateJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnUpdateviaConsolNO_Click(object sender, EventArgs e)
        {

            //var jobFactory = new JobFactorySoapClient();
            //try
            //{
            //    var affectRows = jobFactory.UpdateCreateDateViaShpNO(TxtConsolNO.Text);
            //    if (affectRows > 0)
            //    {
            //        msg1.Text = "Updated Success, affect rows" + affectRows;
            //    }
            //}
            //catch (Exception)
            //{

            //    msg1.Text = "Updated fail pls contact KFMS.HELP@KERRYLOGISTICS.COM for help";
            //}
        }

        protected void Btn_Submit_MasterNO_Click(object sender, EventArgs e)
        {
            var jobFactory = new JobFactorySoapClient();
            try
            {
                var affectRows = jobFactory.UpdateCreateDateViaShpNO(TxtConsolNO.Text);
             
                    msg1.Text = "Updated Success, affect rows " + affectRows;
             
            }
            catch (Exception)
            {

                msg1.Text = "Updated fail pls contact KFMS.HELP@KERRYLOGISTICS.COM for help";
            }
        }
    }
}