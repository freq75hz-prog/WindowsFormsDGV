using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsDGV
{
    internal static class ShohinListHelper
    {
        internal static void ToDataGridView(DataGridView dgv, ShohinList shohinList)
        {
            int rowIndex = 0;
            var shohins = shohinList.Shohins;
            foreach (var shohin in shohins)
            {
                dgv.Rows.Add();
                dgv.Rows[rowIndex].Cells["ShohinID"].Value = shohin.ShohinID;
                dgv.Rows[rowIndex].Cells["ShohinMei"].Value = shohin.ShohinMei;
                dgv.Rows[rowIndex].Cells["ShohinBunrui"].Value = shohin.ShohinBunrui;
                dgv.Rows[rowIndex].Cells["HanbaiTanka"].Value = shohin.HanbaiTanka;
                dgv.Rows[rowIndex].Cells["ShiireTanka"].Value = shohin.ShiireTanka;
                dgv.Rows[rowIndex].Cells["Torokubi"].Value = shohin.Torokubi;
                rowIndex++;
            }
        }
        internal static List<Shohin> DataTableToShohinList(DataTable dt)
        {
            var shohins = new List<Shohin>();
            foreach (DataRow dr in dt.Rows)
            {
                var shohin = new Shohin
                (
                    shohin_id: dr["shohin_id"] as string,
                    shohin_mei: dr["shohin_mei"] as string,
                    shohin_bunrui: dr["shohin_bunrui"] as string,
                    hanbai_tanka: dr["hanbai_tanka"] == DBNull.Value ? default(int?) : Convert.ToInt32(dr["hanbai_tanka"]),
                    shiire_tanka: dr["shiire_tanka"] == DBNull.Value ? default(int?) : Convert.ToInt32(dr["shiire_tanka"]),
                    torokubi: dr["torokubi"] == DBNull.Value ? default(DateTime?) : Convert.ToDateTime(dr["torokubi"])
                );
                shohins.Add(shohin);
            }
            return shohins;
        }
    }
}
