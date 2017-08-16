using System.Web.Services;
using Kerry.ITS.DB;
using Kerry.ITS.DB.Utility;

namespace Kerry.ITS.WS
{
    /// <summary>
    /// JobFactory 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class JobFactory : System.Web.Services.WebService
    {

        private K3DBFactory _k3DB = new K3DBFactory();
        private K3DRDBFactory _k3DRDB = new K3DRDBFactory();


        [WebMethod]
        public int UpdateCreateDateViaShpNO(string shpNO)
        {
            string _consolunidSql = string.Format("SELECT NVL(consollot_unid , unid) " +
                                    " FROM job j " +
                                    " WHERE shpno = trim('{0}') " +

                                    " AND ownerid                       IN ('CNECNSHAA', 'CNSCNSZXA', 'CNECNNGBA', 'CNECNTAOA') " +

                                    " AND voidby                        IS NULL " ,shpNO);

            int consolunid = 0;
            try
            {
                 consolunid =(int)_k3DB.ExecuteDataTable(_consolunidSql).Rows[0][0] ;
            }
            catch (System.Exception ex)
            {
                consolunid = 0;
            }

            if (consolunid==0)
            {
                return 0;
            }

            string sql =string.Format("update job set createdate = sysdate,updatedate =sysdate,updateby = 'CSC' where ( UNID = {0} OR CONSOLLOT_UNID = {0} ) " +
                                       "and ownerid in ('CNECNSHAA','CNSCNSZXA','CNECNNGBA','CNECNTAOA')   and voidby is  null " +
                                       " AND TO_CHAR(j.createdate , 'YYYYMM')< '201707' " +
                                       " AND TO_CHAR(j.createdate, 'YYYYMM') > '201701'", consolunid);

            return _k3DB.ExecuteNonQuery(sql);


        }



    }
}
