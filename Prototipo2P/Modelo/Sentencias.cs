using Prototipo1P;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;



        public OdbcDataReader Insertar(String strTabla, string str_documento_compraenca, string str_codigo_proveedor, string str_fecha_compraenca, string str_total_compraenca, string str_estatus_compraenca)
        {
            try
            {
                //Sentencias
                string str_consulta = "insert into " + strTabla + " values(" + str_documento_compraenca + ",'" + str_codigo_proveedor + "', '" + str_fecha_compraenca + "' ," + str_total_compraenca + ",'" + str_estatus_compraenca + "');";
                comm = new OdbcCommand(str_consulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                Console.WriteLine("Datos registrados.");               
                return mostrar;

            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un error al registrar.");
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public OdbcDataReader Insertar2(String strTabla , string str_documento_ventaenca, string str_codigo_producto, string str_cantidad_ventadet, string str_costo_ventadet, string str_precio_ventadet, string str_codigo_bodega)
        {
            try
            {
                //Sentencias
                string str_consulta = "insert into " + strTabla + " values(" + str_documento_ventaenca + ",'" + str_codigo_producto + "', '" + str_cantidad_ventadet + "' ," + str_costo_ventadet + ",'" + str_precio_ventadet + "','" + str_codigo_bodega + "');";
                comm = new OdbcCommand(str_consulta, cn.conexion());
                OdbcDataReader mostrar = comm.ExecuteReader();
                Console.WriteLine("Datos registrados.");
                return mostrar;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un error al registrar.");
                Console.WriteLine(e.Message);
                return null;
            }
        }










    }
}
