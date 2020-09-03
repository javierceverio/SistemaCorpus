using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corpus
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(linkLabel1.Text);
            MessageBox.Show("La direccion de Mail se copio al portapapeles para que pueda pegarla con las teclas (ctrl + v) en su Pagina de Correo Electronico");
        }
    }
}

/*
Informacion de las distintas Versiones del Sistema Corpus

    Version 1.0.0.18 (Junio de 2019) Fue la primera en entregarse

    Version 1.0.1 (Octubre de 2019) Hubo que modificar la forma en que se dividian los pagos a cada empleado y empleado externo
ya que en la primera version, por cada pago cargado en un trabajo, ese total iba para cada empleado o empleado externo
generando que con un solo cobro practicamente todos recibian incluso hasta mas del total a recibir. El problema fue detectado
por CreISys antes de que el Cliente lo notase. En esta Version el problema fue solucionado!

    Version 1.1.0 (Noviembre de 2019) Se arreglo el problema de que, al haber filtrado un Trabajo, ya sea por numero o Nombre sino
tambien por Estado del Trabajo, al salir de su Presupuesto, este filtrado se perdia. El error se arreglo!
Se modifico (a criterio de CreISys) la forma en que los Usuarios modifican sus contraseñas, ahora deben repetir la contraseña
(y coincidir) antes de poder conformar el cambio. Ademas, se introdujo la posibilidad de que los Usuarios con Nivel de acceso
"Usuario" tambien pudieran modificar su contraseña. Todo quedó funcionando correctamente!
A pedido del Cliente, se modifico la forma en que se cobran los Trabajos, ahora es posible aplicar pagos a empleados y empleados
externos por un lado y "Otros" por el otro, quedando los presupuestos distribuidos de la siguiente manera:
* Los Montos de empleados internos y externos se cobran en los cobros del presupuesto.
* Gastos y Servicios quedan excluidos de los Cobros, se deben pagar en sus respectivos Modulos.
* Otros, toma ahora un camino particular, si se agrego al presupuesto algun Item de la categoria "Otros", en el modulo de cobros
  nos aparecera el monto total designado a "Otros" independientemente de los cobros del presupuesto y podemos destinar cobros a cada
  uno por separado; cabe aclarar que si en el presupuesto no hay ningun Item de la categoria "Otros", entonces solo aparecera la
  posibilidad de cobrar para pagar a los empleados internos y externos (con impuestos, gastos y servicios descontados). De todas
  formas, sigue existiendo la posibilidad de pagar Otros por fuera, en caso de necesitarlo por algun proyecto propio o que no este
  en un Presupuesto.
En el Modulo de Cobros del Trabajo (a criterio de CreISys) se pusieron limites en las sumas, tanto para el Presupuesto como para
Otros, hay un Total para cada ramo y este no podra sobrepasarse, ni al cargar un Nuevo Cobros y tampoco al modificar un cobro cargado
anteriormente. Ahora hay 3 Saldos, el del Total del Trabajo, el de los Cobros del Presupuesto y el de Otros.
Se modifico tambien, que en el Modulo de Cobros a Pagar, en el detalle de cada uno de los Cobros ya no aparece ningun Item de
Gastos, Servicios u Otros (estos aparecen en otra tabla y se pagan por separado), solo empleados internos y externos; este detalle
es similar cuando entramos en el Modulo de Pagos ya realizados.
En Pagos realizados vemos los pagos a Otros separado de los realizados a los empleados.

    IMPORTANTE !!! Se implementaron por primera vez las transacciones en SQL cuando se realiza mas de una consulta simultanea. Funcionaron
correctamente. Cabe aclarar que quedo pendiente implementarlas en el caso de la insercion de los pagos a cada empleado (interno o
externo), al momento de hacerlo no supe como. Queda pendiente para futura actualizacion!

    Version 1.1.1 (25 de Noviembre de 2019) En Balance y en Informe del Balance, se le agrego al filtro "Pago de un Cobro de Otro"
y "Cobro de Otros por Trabajo". Ademas, probando el Sistema detecte que los Pagos de Otros en vez de aparecer como negativos, la
mayoria estaba como positivo excepto por uno, estoy tratando de ubicar a Marcelo para consultarle como uno esta bien y los demas mal.
Cabe destacar que en la Version que yo tengo funciona bien.

    Version 1.2.0 (26 de Noviembre de 2019) A pedido de Marcelo, los Empleados deberan poder ver los montos (solo del usuario activo) ya
cobrados por Corpus pero que todavia no se han pagado. Tambien se genero el Informe del mismo.
Importantisimo, se corrigio la suma a pagar a cada empleado, la distribucion estaba mal porque no restaba al Total del Trabajo el
Total de Otros, solo lo hacia con el primer Monto que encontraba de un Otros. Ademas, se corrigio lo mismo en Pagos, ahora muestra
los montos correctamente. Hable por telefono con Marcelo y le comente lo sucedido, la solucion, le pase un informe de lo que se pago
y de lo que debia pagarse realmente; luego se corrigieron los numeros erroneos en la Base de Datos. Se corrigio en la BD los Pagos de
Otros que por alguna razon aparecian en Positivo. Luego probe el Sistema (desde el Visual Studio) y efectuaba los pagos correctamente en
negativo, faltaria probar que es lo que sucede cuando se realiza desde la PC de Marcelo. A pedido de Marcelo, se elimino de la Base de
Datos todo lo relativo a Cobros y Pagos del Trabajo 264, pues habia sido solo una prueba.

    Version 1.2.1 (2 de Diciembre de 2019) Se corrigio la forma de mostrar algunos totales, que aparezcan con el signo "$", con puntos
para separar los miles y las , para los decimales.
Se agrego a criterio de CreiSys un Sistema de Seguridad para que una vez que un Trabajo ha comenzado a ser cobrado (o fue cobredo en su
totalidad), su presupuesto ya no pueda ser modificado, solo visualizado, pues si se modificaba una vez comenzado a cobrar, ya no se
repartia el dinero en forma pareja o bien algunos de sus integrantes no iban a cobrar en su totalidad.
*/
