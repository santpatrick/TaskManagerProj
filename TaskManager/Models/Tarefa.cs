using System;

namespace API.models
{

    //Data Annotations
    public class Tarefa
    {

        public Tarefa () => CriadoEm = DateTime.Now;
        public int Id { get; set;}
        public string NomeTarefa { get; set; }
        public string Observacao { get; set; }
        public DateTime CriadoEm { get; set; }

        //Relacionamento Usuario
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set;}
        

        //Relacionamento Status
        public int StatusId { get; set; }
        public Status Status {  get; set;}
        
    }
}
    