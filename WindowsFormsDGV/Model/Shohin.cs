using System;

namespace WindowsFormsDGV
{
    public class Shohin
    {        
        public string ShohinID { get; }
        public string ShohinMei { get; }
        public string ShohinBunrui { get; }
        public int? HanbaiTanka { get; }
        public int? ShiireTanka { get; }
        public DateTime? Torokubi { get; }

        public Shohin() { }
        public Shohin(string shohin_id, string shohin_mei, string shohin_bunrui,
                      int? hanbai_tanka, int? shiire_tanka, DateTime? torokubi)
        {
            this.ShohinID = shohin_id;
            this.ShohinMei = shohin_mei;
            this.ShohinBunrui = shohin_bunrui;
            this.HanbaiTanka = hanbai_tanka;
            this.ShiireTanka = shiire_tanka;
            this.Torokubi = torokubi;
        }
    }
}
