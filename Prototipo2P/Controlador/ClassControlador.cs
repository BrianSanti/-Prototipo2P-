using Modelo;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controlador
{

    
    public class ClassControlador
    {

        Sentencias consulta = new Sentencias();

        public OdbcDataReader Insertar_comprasencabezado(string str_documento_compraenca, string str_codigo_proveedor, string str_fecha_compraenca, string str_total_compraenca, string str_estatus_compraenca)
        {
            return consulta.Insertar("compras_encabezado", str_documento_compraenca, str_codigo_proveedor, str_fecha_compraenca, str_total_compraenca, str_estatus_compraenca);

        }
        public OdbcDataReader Insertar_comprasdetalle(string str_documento_compraenca, string str_codigo_producto, string str_cantidad_compradet, string str_costo_compradet, string str_codigo_bodega)
        {
            return consulta.Insertar("compras_detalle", str_documento_compraenca, str_codigo_producto, str_cantidad_compradet, str_costo_compradet, str_codigo_bodega);

        }
        public OdbcDataReader Insertar_ventasencabezado(string str_documento_ventaenca, string str_codigo_cliente, string str_fecha_ventaenca, string str_total_ventaenca, string str_estatus_ventaenca)
        {
            return consulta.Insertar("ventas_encabezado", str_documento_ventaenca, str_codigo_cliente, str_fecha_ventaenca, str_total_ventaenca, str_estatus_ventaenca);

        }
        public OdbcDataReader Insertar_ventasdetalle(string str_documento_ventaenca, string str_codigo_producto, string str_cantidad_ventadet, string str_costo_ventadet, string str_precio_ventadet, string str_codigo_bodega)
        {
            return consulta.Insertar2("ventas_encabezado", str_documento_ventaenca, str_codigo_producto, str_cantidad_ventadet, str_costo_ventadet, str_precio_ventadet, str_codigo_bodega);

        }




    }
}
