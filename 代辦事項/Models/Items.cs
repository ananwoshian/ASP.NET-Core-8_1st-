namespace 代辦事項.Models
{
    public class Items
    {
        public int Id { get; set; }
        // EFcore會自動把 Id這個變數是為主鍵,自動處理流水編號
        public string Content {  get; set; }
        // 不使用與 類別名稱相近的名稱
        public bool IsDone {  get; set; }
    }

}
