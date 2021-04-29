using System;

namespace Dto
{
    public class MotoristaDto
    {
        private String _placa;
        private String _senha;
        private String _motorista;
        private String _carro;
        private DateTime _datadeinicio;

        public String Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        public String Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public String motorista
        {
            get { return _motorista; }
            set { _motorista = value; }
        }

        public String Carro
        {
            get { return _carro; }
            set { _carro = value; }
        }

        public DateTime Data
        {
            get { return _datadeinicio; }
            set { _datadeinicio = value; }
        }
    }
}
