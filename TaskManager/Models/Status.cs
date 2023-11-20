namespace API.models
{

    //Data Annotations
    public class Status
    {
        public Status () => CriadoEm = DateTime.Now;
        public int Id { get; set;}
        public string StatuTarefa { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}


     
       