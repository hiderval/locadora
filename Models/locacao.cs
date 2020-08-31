using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


public partial class locacao

    namespace locacao.Models
    { 
        {

            private int _clienteid;
            private cliente _cliente;

            public virtual int id;
            public virtual int clienteid;
            public virtual Cliente Cliente;

        }

        End Class
}