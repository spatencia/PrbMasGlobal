using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Base
{
    public abstract class EmpleadoBase
    {
        private int _Id;
        private string _Identificacion;
        private string _Nombre;
        private string _Apellido;
        private int _Salario;
        private int _TipoContrato;
        private int _SalarioAnual;
        private string _Contrato;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Identificacion
        {
            get { return _Identificacion; }
            set { _Identificacion = value; }
        }

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public int Salario
        {
            get { return _Salario; }
            set { _Salario = value; }
        }

        public int TipoContrato
        {
            get { return _TipoContrato; }
            set { _TipoContrato = value; }
        }
        public int SalarioAnual
        {
            get { return _SalarioAnual; }
            set { _SalarioAnual = value; }
        }

        public string Contrato
        {
            get { return _Contrato; }
            set { _Contrato = value; }
        }

    }
}
