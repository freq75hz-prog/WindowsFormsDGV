namespace WindowsFormsDGV
{
    public class ShohinQuery
    {
        public static string SelectAll
        {
            get
            {
                var query = @"
                    SELECT shohin_id
                           , shohin_mei
                           , shohin_bunrui
                           , hanbai_tanka
                           , shiire_tanka
                           , torokubi
                    FROM Shohin;
                ";
                return query;
            }
        }
    }
}
