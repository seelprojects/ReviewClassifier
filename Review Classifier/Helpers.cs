using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Classifier
{
    /// <summary>
    /// 
    /// </summary>
    public static class SqlHelpers
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetAppStoreNamesTable()
        {
            var sql = @"SELECT * FROM AppStoreName";
            return sql;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetAppCostsTable()
        {
            var sql = @"SELECT* FROM AppCost;";
            return sql;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetApplicationsTable()
        {
            var sql = @"SELECT* FROM Applications;";
            return sql;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetDetailedApplicationsTable()
        {
            var sql = @"
                        SELECT 
                            ApplicationID,
	                        ApplicationName as 'Application Name', 
                            AppCost as 'Application Cost', 
                            AppStoreName 'Application Store Name', 
                            ApplicationDomainName as 'Applicaiton Domain Name'
                        FROM 
	                        Applications 
	                        LEFT JOIN AppCost on Applications.AppCostID = AppCost.AppCostID 
	                        LEFT JOIN AppStoreName on Applications.AppStoreID = AppStoreName.AppStoreID
	                        LEFT JOIN AppDomains on Applications.AppDomainID = AppDomains.AppDomainID;
                        ";
            return sql;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="appID"></param>
        /// <returns></returns>
        public static string GetReviewsTable(int? appID)
        {
            if (null == appID)
            {
                appID = 1;
            }
            var sql = String.Format(@"
                        SELECT	MainID, 
		                    ApplicationID, 
		                    Comment, 
		                    E_Positive	as 'E.Positive', 
		                    E_Negative	as 'E.Negative', 
		                    E_Neutral	as 'E.Neutral', 
		                    FR_BugReport as 'FR.BugRept', 
		                    FR_UserRequirement as 'FR.UserReq', 
		                    FR_Miscellaneous as 'FR.Misc', 
		                    NFR_Dependability as 'NFR.Depen', 
		                    NFR_Performance as 'NFR.Perf', 
		                    NFR_Supportability as 'NFR.Supprt', 
		                    NFR_Usability as 'NFR.Usab', 
		                    NFR_Miscellaneous as 'NFR.Misc' 
                    FROM 
	                    MAIN 
                    WHERE 
	                    ApplicationID={0}
                        ", appID);
            return sql;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetEPositiveValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            E_Positive = {0} 
                        WHERE 
                            MainID = {1}", 
                            value, MainID);
            return sql;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetENegativeValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            E_Negative = {0} 
                        WHERE 
                            MainID = {1}",
                            value, MainID);
            return sql;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetENeutralValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            E_Neutral = {0} 
                        WHERE 
                            MainID = {1}",
                            value, MainID);
            return sql;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetFRBugReportValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            FR_BugReport = {0} 
                        WHERE 
                            MainID = {1}",
                            value, MainID);
            return sql;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetFRUserRequirementValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            FR_UserRequirement = {0} 
                        WHERE 
                            MainID = {1}",
                            value, MainID);
            return sql;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetFRMiscellaneousValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            FR_Miscellaneous = {0} 
                        WHERE 
                            MainID = {1}",
                            value, MainID);
            return sql;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetNFRDependabilityValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            NFR_Dependability = {0} 
                        WHERE 
                            MainID = {1}",
                            value, MainID);
            return sql;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetNFRPerformanceValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            NFR_Performance = {0} 
                        WHERE 
                            MainID = {1}",
                            value, MainID);
            return sql;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetNFRUsabilityValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            NFR_Usability = {0} 
                        WHERE 
                            MainID = {1}",
                            value, MainID);
            return sql;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetNFRSupportabilityValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            NFR_Supportability = {0} 
                        WHERE 
                            MainID = {1}",
                            value, MainID);
            return sql;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SetNFRMiscellaneousValue(string MainID, bool inputValue)
        {
            int value = 0;
            if (inputValue)
            {
                value = 1;
            }
            var sql = String.Format(@"
                        Update 
                            Main 
                        SET 
                            NFR_Miscellaneous = {0} 
                        WHERE 
                            MainID = {1}",
                            value, MainID);
            return sql;
        }
    }

}
