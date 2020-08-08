using System.Collections.Generic;
using System.Data;

namespace WindowsFormsDGV
{
    internal class ShohinList
    {
        private List<Shohin> _shohins = new List<Shohin>();
        public List<Shohin> Shohins => this._shohins;
        public ShohinList() {
            this._shohins = new List<Shohin>();
        }
        public ShohinList(List<Shohin> shohins)
        {
            this._shohins = new List<Shohin>(shohins);
        }
        public ShohinList(Shohin shohin) 
        {
            this._shohins = new List<Shohin> { shohin };
        }
        public ShohinList(DataTable dt)
        {
            try
            {
                this._shohins = ShohinListHelper.DataTableToShohinList(dt);
            }
            catch
            {
                throw;
            }
        }

        public void AddShohin(Shohin shohin)
        {
            // 既にIDが存在した場合は追加しない。
            var target = this._shohins.Find(x => x.ShohinID == shohin.ShohinID);
            if (target != null)
            {
                return;
            }
            this._shohins.Add(shohin);
        }
        public bool RemoveShohin(Shohin shohin)
        {
            var target = this._shohins.Find(x => x.ShohinID == shohin.ShohinID);
            if (target is null) return false;
            else
            {
                this._shohins.Remove(target);
                return true;
            }
        }                                  
    }
}
