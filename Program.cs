/*
 * Creado por SharpDevelop.
 * Usuario: Ekatos
 * Fecha: 12/11/2019
 * Hora: 10:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Trabajo_final_de_excursion
{
	class Program
	{
		public static void Main(string[] args)
		{
			//arraylists de guardado de numeros------------------------------------------------
			ArrayList numeroexcursion=new ArrayList();
			numeroexcursion.Add(1);
			
			ArrayList numerocliente=new ArrayList();
			numerocliente.Add(1);
			numerocliente.Add(1);
			numerocliente.Add(1);
			
			ArrayList numeroempleado=new ArrayList();
			numeroempleado.Add(1);
			numeroempleado.Add(1);
			numeroempleado.Add(1);
			
			ArrayList numerodetransaccion=new ArrayList();
			
			//arraylist de guardado de objetos
			ArrayList clientes=new ArrayList();
			Cliente primero=new Cliente("Jeremias Springfield",111111,1,0);
			Cliente primero1=new Cliente("Casius Clay",222222,2,0);
			Cliente primero2=new Cliente("Minerva Susana Diaz",333333,3,0);
			clientes.Add(primero);
			clientes.Add(primero1);
			clientes.Add(primero2);
			
			ArrayList empleados=new ArrayList();
			Empleado segundo=new Empleado("Manhattan Shelbyville",444444,1,0);
			Empleado segundo1=new Empleado("Tobias Gimenez",555555,2,0);
			Empleado segundo2=new Empleado("Mirian Felicci",666666,3,0);
			empleados.Add(segundo);
			empleados.Add(segundo1);
			empleados.Add(segundo2);
			
			ArrayList excursiones=new ArrayList();
			Excursion tercero=new Excursion("Parque Pereyra","Quilmes-Gutierrez","5","lunes",1,0,1);
			excursiones.Add(tercero);
			
			ArrayList omnibuses=new ArrayList();
			Omnibus cuarto=new Omnibus("Volvo","FH10",220,220,1,"coche cama","Ocupado");
			Omnibus cuarto1=new Omnibus("Volvo","FH10",220,220,2,"coche cama","Disponible");
			Omnibus cuarto2=new Omnibus("Volvo","FH10",250,250,3,"suite","Disponible");
			omnibuses.Add(cuarto);
			omnibuses.Add(cuarto1);
			omnibuses.Add(cuarto2);
			
			ArrayList agendadeventas=new ArrayList();
			
			MenuPrencipal(clientes,empleados,excursiones,omnibuses, numeroexcursion,numerocliente,numeroempleado,agendadeventas,numerodetransaccion);
			
		}
		static void MenuPrencipal(ArrayList clientes, ArrayList empleados,ArrayList excursiones, ArrayList omnibuses, ArrayList numeroexcursion,ArrayList numerocliente,ArrayList numeroempleado, ArrayList agendadeventas, ArrayList numerodetransacciones){
			Console.Clear();
			int corte;
			do{
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                            Módulo Excursiones                           ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("");
				Console.WriteLine("Selecione una opción del menú.");
				Console.WriteLine("1- Armado de Excursiones.");
				Console.WriteLine("2- Gestión de Empleados.");
				Console.WriteLine("3- Venta de Excursiones.");
				Console.WriteLine("4- Estadísticas.");
				Console.WriteLine("5- Salir del sistema.");
			inicio:
				try{
					corte=int.Parse(Console.ReadLine());
					switch (corte) {
						case 1:
							Mod_Excursion(excursiones,omnibuses,numeroexcursion);
							Console.Clear();
							break;
						case 2:
							Mod_Empleados(empleados,numeroempleado);
							Console.Clear();
							break;
						case 3:
							Mod_VentaExcursion(clientes, excursiones,numerocliente,empleados,agendadeventas,numerodetransacciones, omnibuses);
							Console.Clear();
							break;
						case 4:
							Mod_Estadisticas(clientes,empleados,excursiones);
							Console.Clear();
							break;
						case 5:
							Console.Clear();
							break;
						default:
							Console.WriteLine("INGRESE UN NÚMERO DE OPCIÓN VALIDA");
							Console.WriteLine("Precione una tecla para continuar");
							Console.ReadKey();
							Console.Clear();
							break;
					}
				}catch(Exception){
					Console.WriteLine("OPCIÓN O NÚMERO INVALIDO, INGRESE EL NÚMERO DE LA OPCIÓN A LA QUE DESEADA ACCEDER ");
					goto inicio;
				}
			}while(corte!=5);
			Console.Write("Presione una tecla para continuar ");
			Console.ReadKey(true);
		}
		
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		static void Mod_Excursion(ArrayList excursiones, ArrayList omnibuses,ArrayList numeroexcursion){
			Console.Clear();
			int corte;
			do{
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                        Módulo armado de Excursiones                     ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("");
				Console.WriteLine("Selecione una opción del menú.");
				Console.WriteLine("");
				Console.WriteLine("1- Alta de excursión.");
				Console.WriteLine("2- Baja de excursión.");
				Console.WriteLine("3- Alta de omnibus.");
				Console.WriteLine("4- Baja de omnibus.");
				Console.WriteLine("5- Lista de excursiones.");
				Console.WriteLine("6- Volver");
			inicio:
				try{
					corte=int.Parse(Console.ReadLine());
					switch (corte) {
						case 1:
							SMod_ExcursionAltaEx(excursiones,numeroexcursion,omnibuses);
							Console.Clear();
							break;
						case 2:
							SMod_ExcursionBajaEx(excursiones,omnibuses);
							Console.Clear();
							break;
						case 3:
							SMod_AltaOmni(omnibuses);
							Console.Clear();
							break;
						case 4:
							SMod_BajaOmni(excursiones, omnibuses);
							Console.Clear();
							break;
						case 5:
							SMod_ListExc(excursiones);
							Console.Clear();
							break;
						case 6:
							Console.Clear();
							break;
						default:
							Console.WriteLine("INGRESE UN NÚMERO DE OPCIÓN VALIDA");
							Console.WriteLine("Presione una tecla para continuar");
							Console.ReadKey();
							Console.Clear();
							break;
					}
				}catch(Exception){
					Console.WriteLine("OPCIÓN O NÚMERO INVALIDO, INGRESE EL NÚMERO DE LA OPCIÓN A LA QUE DESEADA ACCEDER");
					goto inicio;
				}
			}while(corte!=6);
		}
		static void SMod_ExcursionAltaEx(ArrayList excursiones,ArrayList numeroexcursion, ArrayList omnibuses){
			Console.Clear();
			int num,verificacion,cve=0,noa=0,contador=0;
			string nex,ncr,deh,dse;
			Excursion Excu=new Excursion();
			verificacion=omnibuses.Count;
			//observa si hay omnibues para poder generar una excursion
			if (verificacion==0) {
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                     Submódulo armado de Excursiones                     ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("INGRESE AL SISTEMA UN OMNIBUS PRIMERO PARA CREAR UNA EXCURSIÓN, ALTA DE OMNIBUS");
				Console.WriteLine("");
				Console.WriteLine("Presione una tecla para volver al menú anterior");
				goto salida;
			}
			//se observa si hay unidades disponibles para poder crear la exursion
			foreach (Omnibus verificardisponibilidad in omnibuses) {
				if (verificardisponibilidad._disponibilidad=="Ocupado") {
					contador++;
				}
				if (contador==verificacion) {
					Console.WriteLine("*******************************************************************************");
					Console.WriteLine("***                     Submódulo armado de Excursiones                     ***");
					Console.WriteLine("*******************************************************************************");
					Console.WriteLine("NO HAY UNIDADES PARA ASIGNAR");
					Console.WriteLine("DE EL ALTA A UN NUEVO OMNIBUS, O DE LA BAJA A UNA EXCURSION PARA DISPONER DE UNIDADES");
					Console.WriteLine("");
					Console.WriteLine("Presione una tecla para volver al menú anterior.");
					goto salida;
				}
			}
			//inicio de la operacion
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                     Submódulo armado de Excursiones                     ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("Ingrese una excursión");
			Console.WriteLine("");
		inicio1:
			Console.WriteLine("Ingrese nombre de la excursion:");
			nex=Console.ReadLine();
			if ((string.IsNullOrWhiteSpace(nex))|(nex==string.Empty)) {
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, VUELVA A CARGAR EL NOMBRE DE LA EXCURSION");
				goto inicio1;
			}
			Console.WriteLine("");
		inicio2:
			Console.WriteLine("Ingrese el recorrido:");
			ncr=Console.ReadLine();
			if ((string.IsNullOrWhiteSpace(ncr))|(ncr==string.Empty)) {
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, VUELVA A CARGAR EL NOMBRE DEL RECORRIDO");
				goto inicio2;
			}
			Console.WriteLine("");
		inicio3:
			Console.WriteLine("Ingrese la duración en horas del recorrido:");
			deh=Console.ReadLine();
			if ((string.IsNullOrWhiteSpace(deh))|(deh==string.Empty)) {
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, VUELVA A CARGAR LA HORA");
				goto inicio3;
			}
			Console.WriteLine("");
		inicio4:
			Console.WriteLine("ingrese día/s de salida de la excursión:");
			dse=Console.ReadLine();
			if ((string.IsNullOrWhiteSpace(dse))|(dse==string.Empty)) {
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, VUELVA A CARGAR EL NOMBRE DEL RECORRIDO");
				goto inicio4;
			}
			Console.WriteLine("");
			Console.WriteLine("---------------------");
			Console.WriteLine("Unidades disponibles|");
			Console.WriteLine("-------------------------------------------------------------------------------");
			//muestra solo las unidades disponibles
			foreach (Omnibus mostraromni in omnibuses) {
				if (mostraromni._disponibilidad=="Disponible") {
					mostraromni.ListaOmnibuesDisponible();
				}
			}
			Console.WriteLine("");
		inicio5:
			Console.WriteLine("Ingrese número de omnibus a asignar:");
			string carga=Console.ReadLine();
			try{
				noa=int.Parse(carga);
			}catch(Exception){
				Console.WriteLine("INGRESE SOLO DATOS NUMÉRICOS O EL NÚMERO DE LA UNIDAD DISPONIBLE EN PANTALLA, NO SE ADMINTEN ESPACIOS VACIOS O LETRAS");
				goto inicio5;
			}
			if (!buscarNumerodeunidad(omnibuses,noa,omnibuses.Count-1)) {
				Console.WriteLine("ESE NUMERO DE UNIDAD NO PERTENECE A LA BASE DE DATOS, VUELVA A CARGAR UNOA UNIDAD DE LA LISTA");
				goto inicio5;
			}
			//busqueda en base al estado de la unidad, disponible u ocupado
			foreach (Omnibus buscaromni in omnibuses) {
				if (buscaromni._numerounidad==noa) {
					if (buscaromni._disponibilidad=="Ocupado") {
						Console.WriteLine("LA UNIDAD ESTÁ ASIGNADA A OTRA EXCURSIÓN");
						goto inicio5;
					}
				}
			}
			for (int i = 0; i < omnibuses.Count; i++) {
				if (noa==((Omnibus)omnibuses[i])._numerounidad) {
					((Omnibus)omnibuses[i])._disponibilidad="Ocupado";
				}
			}
			numeroexcursion.Add(1);
			num=numeroexcursion.Count;
			Excu=new Excursion(nex,ncr,deh,dse,num,cve,noa);
			excursiones.Add(Excu);
			Console.WriteLine("");
			Console.WriteLine("Carga finalizada... Presione una tecla para volver al menú anterior");
		salida:
			Console.ReadKey(true);
		}
		static void SMod_ExcursionBajaEx(ArrayList excursiones,ArrayList omnibuses){
			Console.Clear();
			int borrar,verificacion;
			verificacion=excursiones.Count;
			if (verificacion==0) {
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                      Submódulo baja de Excursiones                      ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("INGRESE UNA EXCURSION PRIMERO PARA SER DADA DE BAJA EN EL MENÚ ALTA DE EXCURSIÓN PRIMERO");
				goto salida;
			}
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                      Submódulo baja de Excursiones                      ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("Listado de excursiones:");
			Console.WriteLine("-------------------------------------------------------------------------------");
			//busca las excursiones creadas
			foreach (Excursion verexcu in excursiones) {
				verexcu.ImprimirExcursion();
			}
			Console.WriteLine("");
		inicio:
			Console.WriteLine("Ingrese el número de excursión que desea borrar:");
			try{
				borrar=int.Parse(Console.ReadLine());
			}catch(Exception){
				Console.WriteLine("ERROR, INGRESE SOLO DATOS NUMÉRICOS");
				goto inicio;
			}
			//si el numero no esta en la lista vuelve a pedir ingresarlo en base a los de la lista
			if (!buscarExcursion(excursiones,borrar,excursiones.Count-1)) {
				Console.WriteLine("EL NÚMERO INGRESADO ES INCORRECTO O NO PERTENECE A UNA EXCURSION MOSTRADA");
				goto inicio;
			}
			//busca la excursion pasado por parametro a traves de borrar el numero de excursion, una vez encontrado, cambia el estado del omnibus a disponible
			//luego se elimina la excursion de la arraylist de excursiones
			foreach (Excursion borrarexcursion in excursiones) {
				if (borrarexcursion.Numerodeexcursion==borrar) {
					foreach (Omnibus cambiarestadoomni in omnibuses) {
						if (borrarexcursion._numerounidad==cambiarestadoomni._numerounidad) {
							cambiarestadoomni._disponibilidad="Disponible";
							cambiarestadoomni._asientosdisponibles=cambiarestadoomni._capacidad;
						}
					}
					excursiones.Remove(borrarexcursion);
					break; //break usado para saltar el codigo para que no genere error de busqueda, se usa para remover elementos de arraylists
				}
			}
			Console.Clear();
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                      Submódulo baja de Excursiones                      ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("Lista actualizada");
			Console.WriteLine("-------------------------------------------------------------------------------");
			//verifica si se eliminaron todas las excursiones del arraylist
			verificacion=excursiones.Count;
			if (verificacion==0) {
				Console.WriteLine("LA LISTA DE EXCURSIONES ESTÁ VACIA");
			}else{
				foreach (Excursion verexcu in excursiones){
					verexcu.ImprimirExcursion();
				}
			}
		salida:
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para continuar");
			Console.ReadKey(true);
		}
		static void SMod_AltaOmni(ArrayList omnibuses){
			Console.Clear();
			string mar,mod,tip,dsp="Disponible";
			int num, cap;
			Omnibus omni=new Omnibus();
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                      Submódulo alta de Omnibus                           ***");
			Console.WriteLine("********************************************************************************");
			Console.WriteLine("");
		inicio1:
			Console.WriteLine("Ingrese marca del omnibus:");
			mar=Console.ReadLine();
			if ((string.IsNullOrWhiteSpace(mar))|(mar==string.Empty)) {
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, VUELVA A CARGAR LA MARCA DEL OMNIBUS");
				goto inicio1;
			}
		inicio2:
			Console.WriteLine("Ingrese modelo del omnibus:");
			mod=Console.ReadLine();
			if ((string.IsNullOrWhiteSpace(mod))|(mod==string.Empty)) {
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, VUELVA A CARGAR EL MODELO DEL OMNIBUS");
				goto inicio2;
			}
		inicio3:
			try{
				Console.WriteLine("Ingrese capacidad del omnibus:");
				cap=int.Parse(Console.ReadLine());
			}catch(Exception){
				Console.WriteLine("INGRESE SOLO DATOS NUMÉRICOS, NO SE ADMITEN CAMPOS VACIOS O LETRAS");
				goto inicio3;
			}
		inicio4:
			try{
				Console.WriteLine("Ingrese número de la unidad:");
				num=int.Parse(Console.ReadLine());
			}catch(Exception){
				Console.WriteLine("INGRESE SOLO DATOS NUMÉRICOS, NO SE ADMITEN CAMPOS VACIOS");
				goto inicio4;
			}
			//busca si existe el numero de unidad ingresado, si existe pide que se vuelva a cargar de nuevo
			foreach (Omnibus buscarnumerounidad in omnibuses) {
				if (buscarnumerounidad._numerounidad==num) {
					Console.WriteLine("EL NÚMERO INGRESADO YA PERTENECE A UNA UNIDAD, CARGUE OTRO NÚMERO DISTINTO");
					goto inicio4;
				}
			}
		inicio5:
			Console.WriteLine("Ingrese tipo del omnibus");
			Console.WriteLine("(Básico, Semi-cama, Coche-cama, suite)");
			tip=Console.ReadLine();
			if ((string.IsNullOrWhiteSpace(tip))|(tip==string.Empty)) {
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, VUELVA A CARGAR EL TIPO DE OMNIBUS");
				goto inicio5;
			}
			omni=new Omnibus(mar,mod,cap, cap,num,tip,dsp);
			omnibuses.Add(omni);
			Console.WriteLine("");
			Console.WriteLine("Carga completa... Presione una tecla para continuar");
			Console.ReadKey(true);
		}
		static void SMod_BajaOmni(ArrayList excursiones, ArrayList omnibuses){
			Console.Clear();
			int baja, verificacion;
			verificacion=omnibuses.Count;
			//verifica que haya un omnibus en el arraylist
			if (verificacion==0) {
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                      Submódulo baja de Omnibus                          ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("INGRESE AL SISTEMA UN OMNIBUS PRIMERO PARA DAR DE BAJA UNA UNIDAD EN ALTA DE OMNIBUS");
				Console.WriteLine("");
				Console.WriteLine("Presione una tecla para volver al menú anterior");
				goto salida;
			}
			//inicio de la operacion del modulo
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                      Submódulo baja de Omnibus                          ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("Lista de omnibus disponibles:");
			Console.WriteLine("");
			foreach (Omnibus omni in omnibuses) {
				omni.ListaOmnibuesDisponible();
			}
			Console.WriteLine("-------------------------------------------------------------------------------");
		inicio:
			Console.WriteLine("Ingrese el número de unidad a dar de baja:");
			try{
				baja=int.Parse(Console.ReadLine());
			}catch(Exception){
				Console.WriteLine("ERROR, INGRESE SOLO DATOS NUMÉRICOS");
				goto inicio;
			}
			//busqueda recursiva booleana para ver si existe el numero pasado para dar de baja
			if (!buscarNumerodeunidad(omnibuses,baja,omnibuses.Count-1)) {
				Console.WriteLine("EL NÚMERO DE UNIDAD ES INCORRECTO O NO PERTENECE A LOS MOSTRADOS");
				Console.WriteLine("INGRESE NUEVAMENTE EL NÚMERO DE UNIDAD A DAR DE BAJA...");
				goto inicio;
			}
			//elimina el omnibus y la excursion si tiene una asignada
			foreach (Omnibus bajaomnibus in omnibuses) {
				if (bajaomnibus._numerounidad==baja ) {
					foreach (Excursion eliminarexcurAsignada in excursiones) {
						if (eliminarexcurAsignada._numerounidad==bajaomnibus._numerounidad) {
							excursiones.Remove(eliminarexcurAsignada);
							break; //usa break para que el foreach no siga buscando y arroje error
						}
					}
					omnibuses.Remove(bajaomnibus);
					break;
				}
			}
			Console.Clear();
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                      Submódulo baja de Omnibus                          ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("Lista de omnibus modificada");
			Console.WriteLine("");
			//verifica si hay omnibuses en el arraylist de omnibuses
			verificacion=omnibuses.Count;
			if (verificacion==0) {
				Console.WriteLine("NO HAY UNIDADES EN LA LISTA DE OMNIBUS");
			}else{
				foreach (Omnibus omni in omnibuses) {
					omni.ListaOmnibuesDisponible();
				}
			}
			Console.WriteLine("-------------------------------------------------------------------------------");
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para volver al menú anterior");
		salida:
			Console.ReadKey(true);
		}
		static void SMod_ListExc(ArrayList excursiones){
			Console.Clear();
			int verificar=excursiones.Count;
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                           Lista de excursiones                          ***");
			Console.WriteLine("*******************************************************************************");
			if (verificar==0) {
				Console.WriteLine("-------------------------------------------------------------------------------");
				Console.WriteLine("NO HAY EXCURSIONES PARA MOSTRAR EL LA LISTA");
				Console.WriteLine("");
				Console.WriteLine("Presione una tecla para volver al menú anterior");
				goto salida;
			}
			Console.WriteLine("Lista de excursiones:");
			Console.WriteLine("-------------------------------------------------------------------------------");
			foreach (Excursion listaexcur in excursiones) {
				listaexcur.ImprimirExcursion();
			}
			Console.WriteLine("Presione una tecla para volver al menú anterior");
		salida:
			Console.ReadKey(true);
		}
		
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		static void Mod_Empleados(ArrayList empleados, ArrayList numeroempleado){
			Console.Clear();
			int corte;
			do{
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                        Módulo gestión de empleados                      ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("");
				Console.WriteLine("Selecione una opción del menú.");
				Console.WriteLine("");
				Console.WriteLine("1- Alta de Empleado.");
				Console.WriteLine("2- Baja de Empleado.");
				Console.WriteLine("3- Lista de Empleados.");
				Console.WriteLine("4- Volver.");
			inicio:
				try{
					corte=int.Parse(Console.ReadLine());
					switch (corte) {
						case 1:
							Console.Clear();
							SMod_AltEmp(empleados, numeroempleado);
							break;
						case 2:
							SMod_BajEmp(empleados);
							Console.Clear();
							break;
						case 3:
							SMod_ListEmp(empleados);
							Console.Clear();
							break;
						case 4:
							Console.Clear();
							break;
						default:
							Console.WriteLine("INGRESE UN NÚMERO DE OPCIÓN VALIDA");
							Console.WriteLine("Presione una tecla para continuar");
							Console.ReadKey();
							Console.Clear();
							break;
					}
				}catch(Exception){
					Console.WriteLine("OPCIÓN O NÚMERO INVALIDO, INGRESE EL NÚMERO DE LA OPCIÓN A LA QUE DESEADA ACCEDER");
					goto inicio;
				}
			}while(corte!=4);
		}
		static void SMod_AltEmp(ArrayList empleados, ArrayList numeroempleado){
			Console.Clear();
			string nom;
			int leg,vpj=0,dni;
			Empleado emple=new Empleado();
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                         Submódulo alta de empleados                     ***");
			Console.WriteLine("*******************************************************************************");
		inicio1:
			Console.WriteLine("Ingrese nombre y apelido del empleado:");
			nom=Console.ReadLine();
			if ((string.IsNullOrWhiteSpace(nom))|(nom==string.Empty)) {
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, VUELVA A CARGAR EL NOMBRE Y APELLIDO");
				goto inicio1;
			}
		inicio2:
			try {
				Console.WriteLine("Ingrese el DNI del empleado");
				dni=int.Parse(Console.ReadLine());
			} catch (Exception) {
				Console.WriteLine("INGRESE SOLO NÚMEROS, VUELVA A CARGAR EL DNI");
				goto inicio2;
			}
			//busca al nuevo empleado en el arraylist de empleados para ver si existe
			foreach (Empleado buscarempleado in empleados) {
				if (buscarempleado.Documento==dni) {
					Console.WriteLine("EL EMPLEADO YA EXISTE EN LA BASE DE DATOS");
					goto salida;
				}
			}
			numeroempleado.Add(1);
			leg=numeroempleado.Count;
			emple=new Empleado(nom,dni,leg,vpj);
			empleados.Add(emple);
			Console.WriteLine("El empleado fue dado de alta satisfactoriamente. Su número de legajo es ({0}).",leg);
		salida:
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para volver al menú anterior.");
			Console.ReadKey(true);
			Console.Clear();
		}
		static void SMod_BajEmp(ArrayList empleados){
			Console.Clear();
			int baja,verificacion;
			verificacion=empleados.Count;
			if (verificacion==0) {
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                         Submódulo baja de empleados                     ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("INGRESE AL SISTEMA UN EMPLEADO PRIMERO PARA PODER VER UN LISTADO DEL PERSONAL, EN ALTA EMPLEADO PRIMERO");
				Console.WriteLine("");
				Console.WriteLine("Presione una tecla para volver al menú anterior");
				goto salida;
			}
			
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                         Submódulo baja de empleados                     ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("Lista de empleados");
			Console.WriteLine("-------------------------------------------------------------------------------");
			foreach (Empleado veremple in empleados) {
				veremple.ImprimirEmpleado();
			}
			Console.WriteLine("");
		inicio:
			Console.WriteLine("Ingrese el número del legajo a dar de baja:");
			try{
				baja=int.Parse(Console.ReadLine());
			}catch(Exception){
				Console.WriteLine("INGRESE SOLO DATOS NUMÉRICOS");
				goto inicio;
			}
			if (!buscarEmpleado(empleados,baja,empleados.Count-1)) {
				Console.WriteLine("EL NÚMERO INGRESADO DE LEGAJO NO PERTENECE A UN EMPLEADO, VUELVA A CARGAR UN NUÉRO DE LEGAJO DE LA LISTA");
				goto inicio;
			}
			foreach (Empleado borrarempleado in empleados) {
				if (borrarempleado.Legajo==baja) {
					empleados.Remove(borrarempleado);//borra el empleado entero en el cual se paró el foreach bajo la condicion del if
					break;//break para saltar el error de seguir buscando algo eliminado
				}
			}
			verificacion=empleados.Count;
			if (verificacion==0) {
				Console.Clear();
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                         Submódulo baja de empleados                     ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("LISTA ACTUALIZADA DE EMPLEADOS:");
				Console.WriteLine("-------------------------------------------------------------------------------");
				Console.WriteLine("NO HAY EMPLEADOS EN LA LISTA");
				Console.WriteLine("");
				Console.WriteLine("Baja exitosa");
				Console.WriteLine("");
				Console.WriteLine("presiones una tecla para continuar");
				goto salida;
			}
			Console.Clear();
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                         Submódulo baja de empleados                     ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("LISTA ACTUALIZADA DE EMPLEADOS:");
			Console.WriteLine("-------------------------------------------------------------------------------");
			foreach (Empleado veremple in empleados) {
				veremple.ImprimirEmpleado();
			}
			Console.WriteLine("");
			Console.WriteLine("Baja exitosa");
			Console.WriteLine("");
			Console.WriteLine("presiones una tecla para continuar");
		salida:
			Console.ReadKey(true);
			Console.Clear();
		}
		static void SMod_ListEmp(ArrayList empleados){
			Console.Clear();
			int verificacion;
			verificacion=empleados.Count;
			if (verificacion==0) {
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                      Submódulo listado de empleados                     ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("INGRESE AL SISTEMA UN EMPLEADO PRIMERO PARA PODER VER UN LISTADO DEL PERSONAL, EN ALTA EMPLEADO PRIMERO");
				Console.WriteLine("");
				Console.WriteLine("Presione una tecla para volver al menú anterior");
				goto salida;
			}
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                      Submódulo listado de empleados                     ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("Lista de empleados");
			Console.WriteLine("-------------------------------------------------------------------------------");
			foreach (Empleado emple in empleados) {
				emple.ImprimirEmpleado();
			}
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para volver al menú anterior");
		salida:
			Console.ReadKey(true);
			Console.Clear();
		}
		
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		static void Mod_VentaExcursion(ArrayList clientes, ArrayList excursiones, ArrayList numerocliente, ArrayList empleados, ArrayList agendadeventas,ArrayList numerodetransacciones,ArrayList omnibuses){
			Console.Clear();
			int corte;
			do{
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                      Módulo venta de Excursiones                        ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("");
				Console.WriteLine("Selecione una opción del menú.");
				Console.WriteLine("");
				Console.WriteLine("1- Alta de Cliente.");
				Console.WriteLine("2- Compra de pasajes para una excursion.");
				Console.WriteLine("3- Devolución de pasajes.");
				Console.WriteLine("4- Volver.");
			inicio:
				try{
					corte=int.Parse(Console.ReadLine());
					switch (corte) {
						case 1:
							SMod_ALtCli(clientes,numerocliente);
							Console.Clear();
							break;
						case 2:
							SMod_ComDePas(clientes,excursiones,empleados,agendadeventas,numerodetransacciones,omnibuses);//se puede usar excursion para guardar ventas?
							Console.Clear();
							break;
						case 3:
							SMod_DevPas(clientes,excursiones,empleados,agendadeventas,omnibuses);
							Console.Clear();
							break;
						case 4:
							Console.Clear();
							break;
						default:
							Console.WriteLine("INGRESE UN NÚMERO DE OPCIÓN VALIDA");
							Console.WriteLine("Presione una tecla para continuar");
							Console.ReadKey();
							Console.Clear();
							break;
					}
				}catch(Exception){
					Console.WriteLine("OPCIÓN O NÚMERO INVALIDO, INGRESE EL NÚMERO DE LA OPCIÓN A LA QUE DESEADA ACCEDER");
					goto inicio;
				}
			}while(corte!=4);
		}
		static void SMod_ALtCli(ArrayList clientes, ArrayList numerocliente){
			Console.Clear();
			string nom;
			int nrc,dni,cpj=0;
			Cliente clie=new Cliente();
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                       Submódulo alta de clientes                        ***");
			Console.WriteLine("*******************************************************************************");
		inicio1:
			Console.WriteLine("Ingrese el nombre y apellido del cliente:");
			nom=Console.ReadLine();
			if ((string.IsNullOrWhiteSpace(nom))|(nom==string.Empty)) {
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, VUELVA A CARGAR EL NOMBRE Y APELLIDO");
				goto inicio1;
			}
		inicio2:
			Console.WriteLine("Ingrese DNI del cliente:");
			try{
				dni=int.Parse(Console.ReadLine());
			}catch(Exception){
				Console.WriteLine("INGRESE SOLO NÚMEROS, VUELVA A CARGAR EL DNI.");
				goto inicio2;
			}
			//busca mediante el dni ingresado, si el cliente esta en el arraylist de clientes
			foreach (Cliente buscar in clientes) {
				if (buscar.Documento==dni) {
					Console.WriteLine("EL CLIENTE YA ESTÁ REGISTRADO EN LA BASE DE DATOS");
					Console.WriteLine("");
					Console.WriteLine("Presione una tecla para volver al menú anterior");
					goto salida;
				}
			}
			Console.WriteLine("");
			numerocliente.Add(1);
			nrc=numerocliente.Count;
			clie=new Cliente(nom,dni,nrc,cpj);
			clientes.Add(clie);
			Console.WriteLine("El cliente fue dado de alta satisfactoriamente. Su número de cliente es "+nrc);
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para continuar.");
		salida:
			Console.ReadKey(true);
			Console.Clear();
		}
		static void SMod_ComDePas(ArrayList clientes,ArrayList excursiones, ArrayList empleados, ArrayList agendadeventas, ArrayList numerodetransacciones, ArrayList omnibuses){
			Console.Clear();
			string carga;
			int num,numt,nex,ndp,nlv, dni, verificar=clientes.Count, veriexc=excursiones.Count,veriempl=empleados.Count;
			Agendadeventa registroventa=new Agendadeventa();
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                      Submódulo compra de pasajes                        ***");
			Console.WriteLine("*******************************************************************************");
			//cortes por si no están los elementos intervinientes en las operaciones del modulo
			if ((veriexc==0)|(verificar==0)|(veriempl==0)) {
				if(veriexc==0){ //que haya excursiones
					Console.WriteLine("NO HAY EXCURSIONES PARA MOSTRAR, CREE UNA EXCURSIÓN EN ALTA DE EXCURSIÓN");
				}
				if (verificar==0) { //que haya clientes
					Console.WriteLine("NO HAY CLIENTES EN LA BASE DE DATOS, DE ALTA A UN NUEVO CLIENTE");
				}
				if (veriempl==0) {//que haya empleados
					Console.WriteLine("NO HAY EMPLEADOS EN LA BASE DE DATOS, DE ALTA A UN NUEVO EMPLEADO");
				}
				goto salida;
			}
		inicio1:
			Console.WriteLine("Ingrese número de cliente:");
			carga=Console.ReadLine();
			try{
				num=int.Parse(carga);
			}catch(Exception){
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, LETRAS O EL NÚMERO DE CLIENTE NO EXISTE, VUELVA A CARGAR EL NÚMERO DE CLIENTE");
				goto inicio1;
			}
			if(!buscarCliente(clientes,num,clientes.Count-1)){
				Console.WriteLine("EL NÚMERO DE CLIENTE NO PERTENECE A LA BASE DE DATOS, CREE UN NUEVO CLIENTE O VUELA A INTENTAR CARGAR EL NÚMERO DE CLIENTE");
				goto salida;
			}
		inicio2:
			Console.WriteLine("Ingrese DNI del cliente:");
			try{
				dni=int.Parse(Console.ReadLine());
			}catch(Exception){
				Console.WriteLine("EL DNI NO CORRESPONDE AL NÚMERO DE CLIENTE, VUELVA A CARGAR EL DNI.");
				goto inicio2;
			}
			//verifica que la persona este registrada en el arraylist clientes de forma recursiva, si no existe o los datos son incorrectos pide cargar de nuevo los datos
			if(!buscarClienteDni(clientes,dni,clientes.Count-1)){
				Console.WriteLine("EL DNI NO CORRESPONDE AL NÚMERO DE CLIENTE, VUELVA A CARGAR EL DNI.");
				goto inicio2;
			}
			Console.WriteLine("-------------------------------------------------------------------------------");
			//muestra la lista de excursiones disponibles
			foreach (Excursion mostrarexcu in excursiones) {
				mostrarexcu.ImprimirExcursionVenta();
			}
			Console.WriteLine("");
		inicio3:
			Console.WriteLine("Ingrese el numero de la excursion a vender:");
			carga=Console.ReadLine();
			try{
				nex=int.Parse(carga);
			}catch(Exception){
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS O LETRAS, VUELVA A CARGAR EL NÚMERO DE EXCURSIÓN");
				goto inicio3;
			}
			//verifica que exista en numero de excursion en el arraylist de excursiones de forma recursiva booleana
			if (!buscarExcursion(excursiones,nex,excursiones.Count-1)){
				Console.WriteLine("EL NÚMERO DE LA OPCIÓN NO ES VALIDO, VUELVA A CARGAR EL NÚMERO DE EXCURSIÓN");
				goto inicio3;
			}
			Console.WriteLine("");
			foreach (Excursion buscarAsi in excursiones) {
				if (buscarAsi.Numerodeexcursion==nex) {
					foreach (Omnibus buscarOmn in omnibuses) {
						if (buscarAsi._numerounidad==buscarOmn._numerounidad) {
							if (buscarOmn._asientosdisponibles>0) {
								Console.WriteLine("Número de asientos disponibles ({0})",buscarOmn._asientosdisponibles);
							}
							if (buscarOmn._asientosdisponibles==0) {
								Console.WriteLine("LA EXCURSION SELECCIONADA YA NO POSEE PASAJES DISPONIBLES");
								Console.WriteLine("SELECCIONE OTRA EXCURSION");
								goto salida;
							}
						}
					}
				}
			}
		inicio4:
			Console.WriteLine("Ingrese la cantidad de pasajes a comprar:");
			carga=Console.ReadLine();
			try{
				ndp=int.Parse(carga);
			}catch(Exception){
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS O LETRAS, VUELVA A CARGAR EL NÚMERO DE PASAJES");
				goto inicio4;
			}
			foreach (Excursion buscarAsi in excursiones) {
				if (buscarAsi.Numerodeexcursion==nex) {
					foreach (Omnibus buscarOmn in omnibuses) {
						if (buscarAsi._numerounidad==buscarOmn._numerounidad) {
							if (buscarOmn._asientosdisponibles>0) {
								int suma=ndp-buscarAsi._asientosdisponibles;
								if (suma<=buscarOmn._asientosdisponibles) {
									buscarOmn._asientosdisponibles-=ndp;
								}
								else{
									Console.WriteLine("No hay suficientes pasajes disponibles, ingrese un numero menor de pasajes.");
									goto inicio4;
								}
							}
						}
					}
				}
			}	
			Console.WriteLine("");
		inicio8:
			Console.WriteLine("Ingrese el número de legajo del vendedor:");
			carga=Console.ReadLine();
			try{
				nlv=int.Parse(carga);
			}catch(Exception){
				Console.WriteLine("NO SE ADMITEN CAMPOS VACIOS, LETRAS O NÚMERO DE LEGAJO INEXISTENTE, VUELVA A CARGAR EL NÚMERO DE LEGAJO DEL EMPLEADO");
				goto inicio8;
			}
			if(!buscarEmpleado(empleados,nlv,empleados.Count-1)){
				Console.WriteLine("EL NÚMERO NO CORRESPONDE AL NÚMERO DE LEGAJO DE UN EMPLEADO, VUELVA A CARGAR UN NÚMERO DE LEGAJO");
				goto inicio8;
			}
			//verifica que exista el numero de legajo del empleado, despues asignacion de la cantidad de ventas de pasajes al empleado
			foreach (Empleado asignarventaempleado in empleados) {
				if (asignarventaempleado.Legajo==nlv) {
					asignarventaempleado._ventaexcursion+=ndp;
				}
			}
			
			//busqueda de la excursion para sumar una venta
			foreach (Excursion sumarexcursion in excursiones) {
				if (sumarexcursion.Numerodeexcursion==nex) {
					sumarexcursion._cantidadvendidadeexcursion+=ndp;
				}
			}
			//busqueda del cliente para asignar pasajes comprados a su historial
			foreach (Cliente ventacliente in clientes) {
				if (ventacliente.Nrocliente==num) {
					ventacliente._comprapasajes+=ndp;
				}
			}			
			
			//adhiere un elemento al arraylist para generar un numero unico de transaccion
			numerodetransacciones.Add(1);
			numt=numerodetransacciones.Count;
			registroventa=new Agendadeventa(numt,nlv,num,nex,ndp);
			agendadeventas.Add(registroventa);
			Console.Clear();
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                      Submódulo compra de pasajes                        ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("");
			Console.WriteLine("Venta exitosa, número de transacción = {0}",numt);
			Console.WriteLine("");
			Console.WriteLine("RECUERDE GUARDAR EL NÚMERO DE TRANSACCIÓN PARA DEVOLUCIONES");
		salida:
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para continuar.");
			Console.ReadKey(true);
			Console.Clear();
		}
		static void SMod_DevPas(ArrayList clientes,ArrayList excursiones,ArrayList empleados,ArrayList agendadeventas,ArrayList omnibuses){
			Console.Clear();
			string num,carga;
			int num1, numt, dni,contar=0, excursion=excursiones.Count,cliente=clientes.Count,empleado=empleados.Count;
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                      Submódulo devolución de pasajes                    ***");
			Console.WriteLine("*******************************************************************************");
			foreach (Cliente buscar in clientes) {
				contar+=buscar._comprapasajes;
			}
			if (contar==0) {
				Console.WriteLine("NO SE REGISTRARON VENTAS DE PASAJES PARA DEVOLVER");
				goto salida;
			}
			
			if ((excursion==0)|(cliente==0)|(empleado==0)) {
				if (excursion==0) {
					Console.WriteLine("INGRESE UNA EXCURSION PRIMERO PARA LA DEVOLUCIÓN DE PASAJES, EN EL MENÚ ALTA DE EXCURSIÓN");
				}
				if (cliente==0) {
					Console.WriteLine("INGRESE UN CLIENTE PRIMERO PARA LA DEVOLUCIÓN DE PASAJES, EN EL MENÚ ALTA DE CLIENTE");
				}
				if (empleado==0) {
					Console.WriteLine("INGRESE UN EMPLEADO PRIMERO PARA LA DEVOLUCIÓN DE PASAJES, EN EL MENÚ ALTA DE EMPLEADO");
				}
				goto salida;
			}
		inicio:
			Console.WriteLine("Ingrese número de cliente");
			num=Console.ReadLine();
			try{
				num1=int.Parse(num);
			}
			catch(Exception){
				Console.WriteLine("EL NÚMERO DE CLIENTE NO PERTENECE A LA BASE DE DATOS, VUELVA A CARGAR EL NÚMERO O CREE UN NUEVO CLIENTE");
				goto inicio;
			}
			if (!buscarCliente(clientes,num1,clientes.Count-1)) {
				Console.WriteLine("EL NÚMERO DE CLIENTE NO PERTENECE A LA BASE DE DATOS, VUELVA A CARGAR EL NÚMERO O CREE UN NUEVO CLIENTE");
				goto salida;
			}
		inicio2:
			try{
				Console.WriteLine("Ingrese DNI del cliente:");
				dni=int.Parse(Console.ReadLine());
			}catch(Exception){
				Console.WriteLine("INGRESE SOLO NÚMEROS, VUELVA A CARGAR EL DNI.");
				goto inicio2;
			}
			if (!buscarClienteDni(clientes,dni,clientes.Count-1)) {
				Console.WriteLine("DNI INCORRECTO, VUELVA A CARGAR EL DNI");
				goto inicio2;
			}
			Console.WriteLine("");
			Console.WriteLine("Ingrese el número de transacción:");
		inicio3:
			carga=Console.ReadLine();
			try{
				numt=int.Parse(carga);
				
			}catch(Exception){
				Console.WriteLine("INGRESE SOLO NÚMEROS");
				goto inicio3;
			}
			foreach (Agendadeventa buscarPas in agendadeventas) {
				if (buscarPas.Numerodetransaccion==numt) {
					if (buscarPas.Cantidaddepasajes<1) {
						Console.Clear();
						Console.WriteLine("*******************************************************************************");
						Console.WriteLine("***                      Submódulo devolución de pasajes                    ***");
						Console.WriteLine("*******************************************************************************");
						Console.WriteLine("EL PASAJERO NO TIENE NINGUN PASAJE PARA SER DEVUELTO.");
						Console.WriteLine("O YA SE SE LE DEVOLVIÓ EL PASAJE.");
						goto salida;
					}
				}
			}
			if (!buscartransaccion(agendadeventas,numt,agendadeventas.Count-1)) {
				Console.Clear();
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                      Submódulo devolución de pasajes                    ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("EL NÚMERO DE TRANSACCIÓN ES INCORRECTOS, VUELVA A CARGAR LOS DATOS");
				Console.WriteLine("");
				goto salida;
			}
			Console.WriteLine("");
			Console.WriteLine("Lista de excursiones:");
			Console.WriteLine("-------------------------------------------------------------------------------");
			foreach (Agendadeventa buscar in agendadeventas) {
				if (buscar.Numerodetransaccion==numt) {
					foreach (Excursion mostrarExc in excursiones) {
						if (buscar.Numerodeexcursion==mostrarExc.Numerodeexcursion) {
							mostrarExc.ImprimirExcursion();
						}
					}
				}
			}
			Console.WriteLine("");
			Console.WriteLine("");
			//revisa agendadeventa, compara los datos ingresados, si son correctos, se descuenta las excursiones al vendedor y comprador
			foreach (Agendadeventa agenda in agendadeventas) {
				if (agenda.Numerodetransaccion==numt) {
					agenda.Cantidaddepasajes-=1;
					foreach (Cliente resCli in clientes) {
						if (agenda.Numerodecliente==resCli.Nrocliente) {
							resCli._comprapasajes-=1;
						}
					}
					foreach (Empleado resEmp in empleados) {
						if (agenda.Numerodelegajo==resEmp.Legajo) {
							resEmp._ventaexcursion-=1;
						}
					}
					foreach (Excursion resExc in excursiones) {
						if (agenda.Numerodeexcursion==resExc.Numerodeexcursion) {
							resExc._cantidadvendidadeexcursion-=1;
							foreach (Omnibus buscarOmn in omnibuses) {
								if (resExc._numerounidad==buscarOmn._numerounidad) {
									buscarOmn._asientosdisponibles+=1;
								}
							}
						}
					}
				}
			}			
			Console.WriteLine("");
			Console.WriteLine("Se de devolverá el 90% del valor abonado");
			Console.WriteLine("");
			Console.WriteLine("Transacción exitosa");
			Console.WriteLine("");
		salida:
			Console.WriteLine("Presione una tecla para continuar");
			Console.ReadKey(true);
			Console.Clear();
		}
		
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		static void Mod_Estadisticas(ArrayList clientes,ArrayList empleados, ArrayList excursiones){
			Console.Clear();
			int corte;
			do{
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                           Módulo Estadísticas                           ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("");
				Console.WriteLine("Selecione una opción del menú.");
				Console.WriteLine("");
				Console.WriteLine("1- Consultar la cantidad de excursiones vendidas.");
				Console.WriteLine("2- Consultar los clientes que más viajan.");
				Console.WriteLine("3- Consultar excursión más solicitada.");
				Console.WriteLine("4- Consultar el operador que más excursiones vende.");
				Console.WriteLine("5- Volver.");
			inicio:
				try{
					corte=int.Parse(Console.ReadLine());
					switch (corte) {
						case 1:
							SMod_ViaVen(clientes);
							Console.Clear();
							break;
						case 2:
							SMod_ConVia(clientes);
							Console.Clear();
							break;
						case 3:
							SMod_ExcSol(excursiones);
							Console.Clear();
							break;
						case 4:
							SMod_OpeVen(empleados);
							Console.Clear();
							break;
						case 5:
							Console.Clear();
							break;
						default:
							Console.WriteLine("INGRESE UN NÚMERO DE OPCIÓN VALIDA");
							Console.WriteLine("Presione una tecla para continuar");
							Console.ReadKey();
							Console.Clear();
							break;
					}
				}catch(Exception){
					Console.WriteLine("OPCIÓN O NÚMERO INVALIDO, INGRESE EL NÚMERO DE LA OPCIÓN A LA QUE DESEADA ACCEDER");
					goto inicio;
				}
			}while(corte!=5);
		}
		static void SMod_ViaVen(ArrayList clientes){
			Console.Clear();
			int cantidad=0;
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                         Submódulo viajes vendidos                       ***");
			Console.WriteLine("*******************************************************************************");
			foreach (Cliente cantidadexcur in clientes) {
				cantidad+=cantidadexcur._comprapasajes;
			}
			Console.WriteLine("La cantidad de excursiones vendidas es ({0})",cantidad);//poner la cantidad en forma de variable
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para continur.");
			Console.ReadKey(true);
			Console.Clear();
		}
		static void SMod_ConVia(ArrayList clientes){
			ArrayList auxiliar=new ArrayList();
			int ver=clientes.Count;
			Console.Clear();
			if (ver==0) {
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                        Submódulo consulta de viajes                     ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("NO HAY CLIENTES REGISTRADOS PARA MOSTRAR SUS VIAJES REALIZADOS");
				goto salida;
			}
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                        Submódulo consulta de viajes                     ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("Lista de clientes y excursiones compradas:");
			Console.WriteLine("");
			auxiliar.Clear();
			foreach (Cliente agregar in clientes) {
				auxiliar.Add(agregar);
			}
			//busqueda recursiva de los clientes
			ordenarPorIntercambioCliente(auxiliar);
			Console.WriteLine(BusquedaRecursivaCliente(auxiliar,auxiliar.Count-1));
		salida:
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para continuar");
			Console.ReadKey(true);
		}
		static void SMod_ExcSol(ArrayList excursiones){
			ArrayList auxiliar=new ArrayList();
			int ver=excursiones.Count;
			Console.Clear();
			if (ver==0) {
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                     Submódulo consulta de excursiones                   ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("NO HAY EXCURSIONES REGISTRADAS PARA MOSTRAR");
				goto salida;
			}
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                     Submódulo consulta de excursiones                   ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("Lista de excursiones más vendidas:");
			auxiliar.Clear();
			//poner lista de los lugares con la cantidad de compras usando una variable numerica PAGINA 9
			foreach (Excursion agregar in excursiones) {
				auxiliar.Add(agregar);			}
			ordenarPorIntercambioExcursiones(auxiliar);
			foreach (Excursion mostrar in auxiliar) {
				mostrar.ImprimirExcursionesVendidas();
			}
		salida:
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para continuar");
			Console.ReadKey(true);
		}
		static void SMod_OpeVen(ArrayList empleados){
			ArrayList auxiliar=new ArrayList();
			int ver=empleados.Count;
			Console.Clear();
			if (ver==0) {
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("***                   Submódulo consulta de ventas por operador             ***");
				Console.WriteLine("*******************************************************************************");
				Console.WriteLine("NO HAY EMPLEADOS REGISTRADOS PARA MOSTRAR");
				goto salida;
			}
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("***                   Submódulo consulta de ventas por operador             ***");
			Console.WriteLine("*******************************************************************************");
			Console.WriteLine("Listado de empleados y ventas:");
			//ordena los empleados por ventas
			foreach (Empleado agregar in empleados) {
				auxiliar.Add(agregar);
			}
			ordenarPorIntercambioEmpleado(auxiliar);
			foreach (Empleado mostrarempleado in auxiliar) {
				mostrarempleado.ImprimirVentaEmpleado();
			}
		salida:
			Console.WriteLine("");
			Console.WriteLine("Presione una tecla para continuar");
			Console.ReadKey(true);
		}
		
		//--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
		
		public static Cliente BusquedaRecursivaCliente(ArrayList clientes, int indice){
			if (indice==0) {
				return ((Cliente)clientes[indice]);
			}else{
				Console.WriteLine(((Cliente)clientes[indice]));
				return BusquedaRecursivaCliente(clientes,indice-1);
			}
		}
		//metodo de ordenamiento de empleados
		public static void ordenarPorIntercambioEmpleado(ArrayList a){
			int indice=a.Count;
			for (int i = 0; i < indice-1; i++) {
				for (int x = i+1; x < indice; x++) {
					if (((Empleado)a[i])._ventaexcursion<((Empleado)a[x])._ventaexcursion) {
						Empleado swap=(Empleado)a[i];
						a[i]=a[x];
						a[x]=swap;
					}
				}
			}
		}
		
		public static void ordenarPorIntercambioCliente(ArrayList a){
			int n=a.Count;
			for (int i = 0; i < n-1; i++) {
				for (int x = i+1; x < n; x++) {
					if (((Cliente)a[i])._comprapasajes>((Cliente)a[x])._comprapasajes) {
						Cliente swap=(Cliente)a[i];
						a[i]=a[x];
						a[x]=swap;
					}
				}
			}
		}
		
		public static void ordenarPorIntercambioExcursiones(ArrayList a){
			int n=a.Count;
			for (int i = 0; i < n-1; i++) {
				for (int x = i+1; x < n; x++) {
					if (((Excursion)a[i])._cantidadvendidadeexcursion<((Excursion)a[x])._cantidadvendidadeexcursion) {
						Excursion swap=(Excursion)a[i];
						a[i]=a[x];
						a[x]=swap;
					}
				}
			}
		}
		//busqueda recursiva booleana
		public static bool buscarNumeroDeexcursion(ArrayList excursiones,int busqueda,int indice){
			bool resu=false;
			if (busqueda==(((Excursion)excursiones[indice]).Numerodeexcursion)) {
				resu=true;
				return resu;
			}
			if (indice==0) {
				return resu;
			}
			if (busqueda!=(((Excursion)excursiones[indice]).Numerodeexcursion)) {
				return buscarNumeroDeexcursion(excursiones,busqueda,indice-1);
			}
			return resu;
		}
		
		public static bool buscarNumerodeunidad(ArrayList omnibuses,int busqueda,int indice){
			bool resu=false;
			if (busqueda==(((Omnibus)omnibuses[indice])._numerounidad)) {
				resu=true;
				return resu;
			}
			if (indice==0) {
				return resu;
			}
			if (busqueda!=(((Omnibus)omnibuses[indice])._numerounidad)) {
				return buscarNumerodeunidad(omnibuses,busqueda,indice-1);
			}
			return resu;
		}
		
		public static bool buscarOmnibus(ArrayList omnibuses, string disponiblilidad,int numerounidad,int indice){
			bool resu=false;
			if ((disponiblilidad==((Omnibus)omnibuses[indice])._disponibilidad)&(numerounidad==((Omnibus)omnibuses[indice])._numerounidad)) {
				return true;
			}
			if (indice==0) {
				return resu;
			}
			if((disponiblilidad!=((Omnibus)omnibuses[indice])._disponibilidad)&(numerounidad!=((Omnibus)omnibuses[indice])._numerounidad)){
				return buscarOmnibus(omnibuses,disponiblilidad,numerounidad, indice-1);
			}
			return resu;
		}
		
		public static bool buscarExcursion(ArrayList excursiones, int busqueda,int indice){
			bool resu=false;
			if (busqueda==((Excursion)excursiones[indice]).Numerodeexcursion) {
				return true;
			}
			if (indice==0) {
				return resu;
			}
			if(busqueda!=((Excursion)excursiones[indice]).Numerodeexcursion){
				return buscarExcursion(excursiones,busqueda,indice-1);
			}
			return resu;
		}
		
		public static bool buscarCliente(ArrayList clientes,int busqueda,int indice){
			bool resu=false;
			if (busqueda==((Cliente)clientes[indice]).Nrocliente) {
				return true;
			}
			if (indice==0) {
				return resu;
			}
			if (busqueda!=((Cliente)clientes[indice]).Nrocliente){
				return buscarCliente(clientes,busqueda,indice-1);
			}
			return resu;
		}
		
		public static bool buscartransaccion(ArrayList agendadeventas,int busqueda,int indice){
			bool resu=false;
			if (busqueda==((Agendadeventa)agendadeventas[indice]).Numerodetransaccion) {
				return true;
			}
			if (indice==0) {
				return resu;
			}
			if (busqueda!=((Agendadeventa)agendadeventas[indice]).Numerodetransaccion) {
				return buscartransaccion(agendadeventas,busqueda,indice-1);
			}
			return resu;
		}
		
		public static bool buscarClienteDni(ArrayList clientes,int busqueda,int indice){
			bool resu=false;
			if (busqueda==((Cliente)clientes[indice]).Documento) {
				return true;
			}
			if (indice==0) {
				return resu;
			}
			if (busqueda!=((Cliente)clientes[indice]).Nrocliente){
				return buscarClienteDni(clientes,busqueda,indice-1);
			}
			return resu;
		}
		
		public static bool buscarEmpleado(ArrayList empleados,int numerolegajo,int indice){
			bool resu=false;
			if (numerolegajo==((Empleado)empleados[indice]).Legajo) {
				return true;
			}
			if (indice==0) {
				return resu;
			}
			if(numerolegajo!=((Empleado)empleados[indice]).Legajo){
				return buscarEmpleado(empleados,numerolegajo,indice-1);
			}
			return resu;
		}
	}
}