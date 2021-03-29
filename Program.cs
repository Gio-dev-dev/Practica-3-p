/*
 * Created by SharpDevelop.
 * User: EQUIPO
 * Date: 28/03/2021
 * Time: 12:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_3_programación_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("¡Hola bienvenido a cuida tú mascota!");
			
			// TODO: Implement Functionality Here
			
			// Profe cuando colocaba opción 3 que era mediana me daba error no se por solo me dejo opción 1 y 2
			// Intente trabajar con el condicinal for
			
			
		
			int opción= 0;
			int peso  = 0;			
			string dato= "";
			
			
			
			do{
				Console.WriteLine("Elija la opción de su preferencia 1= Miniatura|| 2= Pequeño|| 3= Salir");
				dato = Console.ReadLine();
				opción = Convert.ToInt32(dato);
				
				
			
			
				
			
		if (opción == 1)
				for(int i = 0; i < 2; i++){
				Console.WriteLine("Ingrese el peso de su mascota miniatura");
				dato= Console.ReadLine();
				Console.WriteLine("Si usted selecciono 2 su mascota debe ingerir 50 gramos de alimento al día");
				Console.WriteLine("Si usted selecciono 3 su mascota debe ingerir 60 gramos de alimento al día");
				Console.WriteLine("Si usted selecciono 4 su mascota debe ingerir 70 gramos de alimento al día");
				Console.WriteLine("Si usted selecciono 5 su mascota debe ingerir 90 gramos de alimento al día");	
				Console.WriteLine("Si la actividad del perro es alta 60 mantenga la aliemntación indicada");
				Console.WriteLine("Si la actividad del perro es normal 55 bajar 5 gramos de aliemtación diaria");
				Console.WriteLine("Si la actividad del perro es baja 45 bajar 10 gramos de aliemtación diaria");
				
				}
			
				if (opción == 2)
			    Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota pequeña!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso ==6)
                {
                	Console.WriteLine("Su perro debe comer 100 gramos de alimento diario.");
                	Console.WriteLine("Si la actividad del perro es alta 115 mantenga la aliemntación indicada");
				    Console.WriteLine("Si la actividad del perro es normal 100 bajar 20 gramos de aliemtación diaria");
				    Console.WriteLine("Si la actividad del perro es baja 85 bajar  30 gramos de aliemtación diaria");
				

                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro pequeño, en el siguiente lo podra encontrar!!!"); 

                }
			    
                Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota pequeña!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso <= 5 && peso >= 2) 
                {
                	Console.WriteLine("Su perro debe comer 110 gramos de alimento diario.");
                	Console.WriteLine("Si la actividad del perro es alta 130 mantenga la aliemntación indicada");
				    Console.WriteLine("Si la actividad del perro es normal 110 bajar 25 gramos de aliemtación diaria");
				    Console.WriteLine("Si la actividad del perro es baja 95 bajar 35 gramos de aliemtación diaria");

                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro pequeño, en el siguiente lo podra encontrar!!!"); 

                }
                Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota pequeña!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso ==8)
                {
                	Console.WriteLine("Su perro debe comer 130 gramos de alimento diario.");
                	Console.WriteLine("Si la actividad del perro es alta 140 mantenga la aliemntación indicada");
				    Console.WriteLine("Si la actividad del perro es normal 120 bajar 30 gramos de aliemtación diaria");
				    Console.WriteLine("Si la actividad del perro es baja 105 bajar 40 gramos de aliemtación diaria");


                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro pequeño, en el siguiente lo podra encontrar!!!"); 

                }
                 Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota pequeña!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso ==9)
                {
                	Console.WriteLine("Su perro debe comer 140 gramos de alimento diario.");
                	Console.WriteLine("Si la actividad del perro es alta 150 mantenga la aliemntación indicada");
				    Console.WriteLine("Si la actividad del perro es normal 130 bajar 35 gramos de aliemtación diaria");
				    Console.WriteLine("Si la actividad del perro es baja 115 bajar 45 gramos de aliemtación diaria");


                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro pequeño, en el siguiente lo podra encontrar!!!"); 

                }
                Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota pequeña!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);
               

                if(peso ==10)
                {
                	Console.WriteLine("Su perro debe comer 170 gramos de alimento diario.");
                	Console.WriteLine("Si la actividad del perro es alta 190 mantenga la aliemntación indicada");
				    Console.WriteLine("Si la actividad del perro es normal 170 bajar 40 gramos de aliemtación diaria");
				    Console.WriteLine("Si la actividad del perro es baja 150 bajar 50 gramos de aliemtación diaria");


                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro pequeño, en el siguiente lo podra encontrar!!!"); 

                }
              
                	Console.WriteLine("Por favor ingrese el peso de su mascota mediana");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso ==11)
                {
                	Console.WriteLine("Su perro debe comer 185 gramos de alimento diario.");

                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro mediano, en el siguiente lo podra encontrar!!!"); 

                }
                 Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota mediana!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso ==12)
                {
                	Console.WriteLine("Su perro debe comer 195 gramos de alimento diario.");

                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro mediano, en el siguiente lo podra encontrar!!!"); 

                }
                 Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota mediana!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso ==13)
                {
                	Console.WriteLine("Su perro debe comer 200 gramos de alimento diario.");

                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro mediano, en el siguiente lo podra encontrar!!!"); 

                }
                 Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota mediana!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso ==14)
                {
                	Console.WriteLine("Su perro debe comer 205 gramos de alimento diario.");

                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro mediano, en el siguiente lo podra encontrar!!!"); 

                }
                Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota mediana!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso ==15)
                {
                	Console.WriteLine("Su perro debe comer 210 gramos de alimento diario.");

                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro mediano, en el siguiente lo podra encontrar!!!"); 

                }
                 Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota mediana!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso ==16)
                {
                	Console.WriteLine("Su perro debe comer 215 gramos de alimento diario.");

                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro mediano, en el siguiente lo podra encontrar!!!"); 

                }
                Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota mediana!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso ==17)
                {
                	Console.WriteLine("Su perro debe comer 220 gramos de alimento diario.");

                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro mediano, en el siguiente lo podra encontrar!!!"); 

                }
                  Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota mediana!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso <= 50 && peso >= 18)
                {
                	Console.WriteLine("Su perro debe comer de  230  300 gramos de alimento diario.");
                	Console.WriteLine("Debe darle 10 gramos de alimentos por cada kiligramo más");
               
                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro mediano, en el siguiente lo podra encontrar!!!"); 
                    
                    
                }
                 
                	Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota Grande!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso >=50)
                {
                	Console.WriteLine("Su perro debe comer 405 gramos de alimento diario.");
                	Console.WriteLine("Si su perro tinene un peso de entre 50 y 60 por cada kilo más debe darle 10 gramos extra ");
                	
               
                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro Grande, en el siguiente lo podra encontrar!!!"); 
                	
                }
                Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota Grande!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso >=60)
                {
                	Console.WriteLine("Su perro debe comer 450 gramos de alimento diario.");
                	Console.WriteLine("Si su perro tinene un peso de entre 60 y 70 por cada kilo más debe darle 15 gramos extra ");
                	
               
                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro Grande, en el siguiente lo podra encontrar!!!"); 
                	
                }
                  Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota Grande!");
                dato = Console.ReadLine();
                peso = Convert.ToInt32(dato);

                if(peso >=70)
                {
                	Console.WriteLine("Su perro debe comer 485 gramos de alimento diario.");
                	Console.WriteLine("Si su perro tinene un peso de entre 70 y 80 por cada kilo más debe darle 15 gramos extra ");
                	
               
                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro Grande, en el siguiente lo podra encontrar!!!"); 
                	
                }
                Console.WriteLine("¡Hola, Por favor ingrese el peso de su mascota Grande!");
                dato = Console.ReadLine();
               
                peso = Convert.ToInt32(dato);
                if(peso >=80)
                {
                	Console.WriteLine("Su perro debe comer 510 gramos de alimento diario.");
                	Console.WriteLine("Si su perro tinene un peso de entre 80 y 90 por cada kilo más debe darle 20 gramos extra ");
                
               
                }
                else
                {
                    Console.WriteLine("¡¡¡No cuanta con los caractres de un perro Grande, en el siguiente lo podra encontrar!!!"); 
                	
                }
                	}while (opción !=3);
				
                



			
		
			Console.ReadLine();
			
		}
	}
}