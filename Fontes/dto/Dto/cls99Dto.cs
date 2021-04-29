using System;

namespace Dto
{
    public class cls99Dto
    {
        private int _idCarro;
        private DateTime _datacorida;
        private String _combustivel;
        private String _horas;
        private String _km;
        private int _corridas;
        private String _ganhos;
        private String _gastos;
        private String _obs99;

        public int IdCarro
        {
            get { return _idCarro; }
            set { _idCarro = value; }
        }

        public DateTime DatadaCorridas
        {
            get { return _datacorida; }
            set { _datacorida = value; }
        }

        public String Combustivel
        {
            get { return _combustivel; }
            set { _combustivel = value; }
        }

        public String Horas
        {
            get { return _horas; }
            set { _horas = value; }
        }

        public String KM
        {
            get { return _km; }
            set { _km = value; }
        }

        public int Corridas
        {
            get { return _corridas; }
            set { _corridas = value; }
        }

        public String Ganhos
        {
            get { return _ganhos; }
            set { _ganhos = value; }
        }

        public String Gastos
        {
            get { return _gastos; }
            set { _gastos = value; }
        }

        public String OBS99
        {
            get { return _obs99; }
            set { _obs99 = value; }
        }
    }
}
