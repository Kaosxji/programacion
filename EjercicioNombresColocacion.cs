/*
En este ejercicio practicarás el nombre de las cosas
y su ubicación dentro del código.
Por cada línea que tenga una declaración de namespace,
clase, método, atributo, parámetro, variable, así como 
en ciclos y bloques condicionales, deberás indicar con un comentario 
qué es lo que se está declarando y dentro de qué bloque está.

No copies y pegues, debes transcribir.
NO: class Elefante
SI: clase Elefante

Observa con atención los primeros ejemplos.
*/

using System;//El using no es una declaración

namespace Ejemplos//Declaración de espacio de nombres Ejemplos
{
    class Elefante//Declaración de clase Elefante dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Elefante
        public int Edad;
        public float Peso;

        //Declaración de método Comer dentro de clase Elefante
        //Declaración de parámetro comida dentro de método comer
        public void Comer(string comida)
        {
            
            for(int i = 0; i < 10; i++)//Ciclo for dentro de método Comer
            {
                int porcionesComidas = i + 1;//Declaración de variable local porcionesComidas dentro de ciclo for
            }
            Console.WriteLine($"{Nombre} está comiendo {comida}.");//Esta línea no llevará comentario
        }

        public void Rugir()//Declaracion de metodo "rugir" dentro de la clase Elefante.
        {
            int distanciaEscuchante = 100;//Declaracion de variable local "DistanciaEscuchante" dentro del metodo .
            Console.WriteLine($"{Nombre} está rugiendo.");
        }
        //Declaracion de metodo "Dormir" dentro de la clase Elefante.
        //Declaracion de parametros "Horas" dentro del metodo "dormir".
        public void Dormir(int horas)
        {
            if(horas > 10)//Deaclaracion de bloque condicionante "if" dentro del metodo Dormir.
            {
                float energiaGanada = 15;//Uso de variable local flotante "EnergiaGanada" dentro del bloque condicionante if.
            }
            Console.WriteLine($"{Nombre} está durmiendo durante {horas} horas.");
        }
    }

    class Zapatero//Declaración de clase Zapatero dentro de namespace Ejemplos
    {
        public string Nombre; //Declaracion de atributo Nombre dentro de clase Zapatero
        public string Especialidad;//Declaracion de atributo "Especialidad"  dentro de la clase zapatero.
        public int AñosExperiencia;//Declaracion de atributo "AñosExperiencias" dentro de la clase zapatero.

        //declaracion de metodo "RepararZapatos" dentro de la clase Zapatero.
        //Declareacion de parametros "tipo", "cantidad " dentro de metodo RepararZapatos.
        public void RepararZapatos(string tipo, int cantidad)
        {
            int precio = 50;//Uso Variable local "precio" dentro del metodo RepararZapatos.
            if (tipo == "tenis") //Declaracion de bloque condicional if. 
            {
                precio = 100;//Uso de variable local "precio" dentro de bloque condiconal if.
            }
            Console.WriteLine($"{Nombre} está reparando {cantidad} zapatos de tipo {tipo} a precio {precio}");
        }
        //Declaracion de metodo "CrearZapato" dentro de la clase Zapatero.
        //Declareacion de parametros "estilo", "material " dentro de metodo RepararZapatos.
        public void CrearZapato(string estilo, string material)
        {
            for(int i = 0; i < 100; i++)//Declaracion de ciclo for dentro del metodo "CrearZapato".
            {
                if(estilo == "industrial")//Declaracion de bloque condicional "if" dentro del ciclo "for".
                {
                    Console.WriteLine("Golpeando fuerte");
                }
                else//Declaracion de bloque condiconla "else" dentro de ciclo"for"
                {
                    Console.WriteLine("Golpeando normal");

                }
            }
            Console.WriteLine($"{Nombre} está creando un zapato de estilo {estilo} con material {material}.");
        }
        //Declaracion de metodo "MedirPie" dentro de la clase Zapatero.
        //Declareacion de parametro "numeroPie" dentro de metodo "MedirPie".
        public void MedirPie(int numeroPie)
        {
            string cliente;//declarcion de variable local "Cliente" dentro del metodo "MedirPie"
            if (numeroPie > 20) //Declaracion de bloque condicional if dentro del metodo "MedirPie"
            {
                cliente = "Adulto";//Uso de varaiable local "Cliente" dentro del bloque condicionla "if"
            }
            else//Declaracion de bloque condicional "else" dentro del metodo "MedirPie".
            {
                cliente = "Niño";//Uso de variable local "Cliente" dentro del bloque condicional "else".
            }
            Console.WriteLine($"{Nombre} está midiendo el pie para el número {numeroPie}.");
        }
    }

    class Television//Declaracion de clase "Television" dentro de "namespace Ejemplos".
    {
        public string Marca;
        public int Pulgadas;   //Declaracion de atributos "Marca", "Pulgadas" y "Encendida" dentro de clase "Television".
        public bool Encendida;

        public void Encender()//Declaracion de metodo "Encender" dentro de clase "Television".
        {
            Encendida = true;//Uso de variable local "Encendida" dentro del metodo "Encender"
            float consumoLuz = 0.05f;//Declaracion de variable "consumoluz" dentro del metodo "Encender" 
            Console.WriteLine($"La televisión de {Pulgadas} pulgadas, marca {Marca}, está encendida.");
        }

        public void CambiarCanal(int canal)
        {
            for(int i = 1; i < canal; i++)
            {
                Console.WriteLine($"Cambiando a canal {i}.");
            }            
        }

        public void AjustarVolumen(int nivel)
        {
            if (nivel > 100)
            {
                nivel = 0;
            }
            Console.WriteLine($"Ajustando el volumen a nivel {nivel}.");
        }
    }

    class Guitarra
    {
        public string Marca;
        public string Tipo;
        public int Cuerdas;

        public void TocarCuerda(int numeroCuerda)
        {
            if(numeroCuerda == 6)
            {
                string nota = "Mi";
            }
            else if (numeroCuerda == 5)
            {
                string nota = "La";
            }
            Console.WriteLine($"Tocando la cuerda {numeroCuerda} de la guitarra {Marca}.");
        }

        public void AfinarGuitarra(bool afinada)
        {
            if (afinada)
            {
                Console.WriteLine($"La guitarra {Marca} está afinada.");
            }
            else
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Afinando la guitarra {Marca}.");
                }                
            }
        }

        public void CambiarTipo(string nuevoTipo)
        {
            Tipo = nuevoTipo;
            Console.WriteLine($"Cambiando el tipo de la guitarra a {nuevoTipo}.");
        }
    }

}
