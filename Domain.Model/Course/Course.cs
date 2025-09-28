using SectionEntity = Domain.Model.Section.Section;
using SubjectEntity = Domain.Model.Subject.Subject;

namespace Domain.Model.Course
{
    public class Course : BusinessEntity
    {
        public int AcademicYear { get; private set; }
        public int Capacity { get; private set; }

        private int _idSection;
        private SectionEntity _section;

        public int IDSection
        {
            get => _section?.ID ?? _idSection;
            private set => _idSection = value;
        }

        public SectionEntity Section
        {
            get => _section;

            private set
            {
                _section = value;
                if (value != null && _idSection != value.ID)
                {
                    _section.ID = value.ID;
                }
            }
        }

        private int _idSubject;
        private SubjectEntity _subject;

        public int IDSubject
        {
            get => _subject?.ID ?? _idSubject;
            private set => _idSubject = value;
        }

        public SubjectEntity Subject
        {
            get => _subject;

            private set
            {
                _subject = value;
                if (value != null && _idSubject != value.ID)
                {
                    _subject.ID = value.ID;
                }
            }
        }

        private Course() { }

        public Course(int capacity, int academicYear, int sectionID, int subjectID )
        {
            SetCapacity(capacity);
            SetIDSection(sectionID);
            SetAcademicYear(academicYear);
            SetIDSubject(subjectID);        
        }

        public void SetCapacity(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentException("El cupo del curso debe ser mayor que 0.", nameof(capacity));
            Capacity = capacity;
        }

        public void SetIDSection(int sectionId)
        {
            if (sectionId < 0)
                throw new ArgumentException("El ID de la especialidad debe ser mayor que 0.", nameof(sectionId));
            _idSection = sectionId;
        }

        public void SetIDSubject(int subjectId)
        {
            if (subjectId < 0)
                throw new ArgumentException("El ID de la materia debe ser mayor que 0.", nameof(subjectId));
            _idSection = subjectId;
        }


        public void SetAcademicYear(int year)
        {
            //CUANDO SE SETEA UN CURSO EL AÑO ACADEMICO ES EL ACTUAL
            AcademicYear = DateTime.Now.Year; 

            /* CUANDO SE SETEA UN CURSO SE PUEDE MODIFICAR EL AÑO ACADEMICO 
            if (year < 1948 || year > (DateTime.Now.Year))
                throw new ArgumentException("El año academico es inválido", nameof(year));
            AcademicYear = year;*/
        }

    }
}
