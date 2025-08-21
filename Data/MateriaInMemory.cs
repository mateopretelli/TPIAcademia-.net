using Domain.Model;

namespace Data
{
    public class MateriaInMemory
    {


        public static List<Materia> Materias;

        static MateriaInMemory()
        {
            Materias = new List<Materia> { };

            Materia mat = new Materia("Matemática Discreta", 4, 64, 101);
            mat.SetId(1);
            mat.SetState("Active");
            Materias.Add(mat);

            mat = new Materia("Algoritmos y Estructuras de Datos", 6, 96, 101);
            mat.SetId(2);
            mat.SetState("Active");
            Materias.Add(mat);

            mat = new Materia("Programación Orientada a Objetos", 5, 80, 101);
            mat.SetId(3);
            mat.SetState("Active");
            Materias.Add(mat);

            mat = new Materia("Arquitectura de Computadoras", 4, 64, 101);
            mat.SetId(4);
            mat.SetState("Active");
            Materias.Add(mat);

            mat = new Materia("Base de Datos", 5, 80, 102);
            mat.SetId(5);
            mat.SetState("Active");
            Materias.Add(mat);

            mat = new Materia("Sistemas Operativos", 4, 64, 102);
            mat.SetId(6);
            mat.SetState("Active");
            Materias.Add(mat);

            mat = new Materia("Redes de Computadoras", 3, 48, 102);
            mat.SetId(7);
            mat.SetState("Active");
            Materias.Add(mat);

            mat = new Materia("Ingeniería de Software", 3, 48, 103);
            mat.SetId(8);
            mat.SetState("Active");
            Materias.Add(mat);

            mat = new Materia("Teoría de la Computación", 4, 64, 103);
            mat.SetId(9);
            mat.SetState("Active");
            Materias.Add(mat);

            mat = new Materia("Seguridad Informática", 3, 48, 103);
            mat.SetId(10);
            mat.SetState("Active");
            Materias.Add(mat);
        }

    }
}
