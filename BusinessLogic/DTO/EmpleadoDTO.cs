using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Base;

namespace BusinessLogic.DTO
{
    public class EmpleadoDTO : EmpleadoBase
    {

        /// <summary>
        /// Crear Empleado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="identificacion"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="salario"></param>
        /// <param name="tipoContrato"></param>
        public EmpleadoDTO(int id, int identificacion, string nombre, string apellido, int salario, int tipoContrato)
        {
            this.Id = id;
            this.Identificacion = identificacion;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Salario = salario;
            this.TipoContrato = tipoContrato;
        }

        public void CalcularSalarioAnual()
        {
            // SI TIPO CONTRATO ES 1 ENTONCES SALARIO POR HORA, SINO SALARIO MENSUAL
            if (this.TipoContrato.Equals(1))
                this.SalarioAnual = 120 * this.Salario * 12;
            else
                this.SalarioAnual = this.Salario * 12;
        }

    }
}
