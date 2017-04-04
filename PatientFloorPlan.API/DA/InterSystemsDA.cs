using InterSystems.Data.CacheClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PatientFloorPlan.API.DA
{
    public class InterSystemsDA
    {
        private static DataTable dt;
        public static DataTable DTBindDataCommand(string cmdString, string conString)
        {
            dt = new DataTable();

            using(var con = new CacheConnection(conString))
            {
                con.Open();
                using(var da = new CacheDataAdapter(cmdString, con))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public static DataSet DSBindDataCommand(string cmdString, string conString)
        {
            DataSet ds = new DataSet();

            using(var con = new CacheConnection(conString))
            {
                con.Open();
                using(var da = new CacheDataAdapter(cmdString, con))
                {
                    da.Fill(ds);
                }
            }

            return ds;
        }

        public static DataTable DTBindProcedure(string procedureName, string conString, Dictionary<string, object> para)
        {
            dt = new DataTable();

            using(var con = new CacheConnection(conString))
            {
                con.Open();
                using(var cmd = new CacheCommand(procedureName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (KeyValuePair<string, object> kvp in para)
                        cmd.Parameters.Add(kvp.Key, kvp.Value);
                    if(para != null)
                    {
                        using(CacheDataReader dr = cmd.ExecuteReader())
                        {
                            dt.Load(dr);
                            return dt;
                        }
                    }
                }
            }

            return dt; 
        }
    }
}