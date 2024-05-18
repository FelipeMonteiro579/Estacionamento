
using System.Diagnostics.CodeAnalysis;

namespace SistemaEstacionamento.Models
{
    public class Veiculo
    {
        private string _placa = string.Empty;
        private DateTime _horaInicio;
        private DateTime _horaFinal;

        #region "Getters and Setters"
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public DateTime HoraInicio
        {
            get { return _horaInicio;}
            set { _horaInicio = value;}
        }

        public DateTime HoraFinal
        { 
            get { return _horaFinal;} 
            set { _horaFinal = value;}
        }
        #endregion
    }
}
