using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api_Usuario.Validations;

namespace API.models
{

    //Data Annotations
    public class Usuario
    {
        public int Id { get; set;}
      
        public string Nome { get; set; }  
        
        public string Cpf { get; set; }        
        public string Email { get; set; }

        public DateTime? CriadoEm { get; set; }

        public DateTime Nascimento { get; set; }

        
    }
}