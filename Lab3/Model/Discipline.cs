using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3.Model
{
    /// <summary>
    /// Хранит учебные дисциплины.
    /// </summary>
    class Discipline
    {
        /// <summary>
        /// Дисциплина математика.
        /// </summary>
        private bool _math;
        /// <summary>
        /// Дисциплина программирование.
        /// </summary>
        private bool _programming;
        /// <summary>
        /// Дисциплина проект.
        /// </summary>
        private bool _project;

        /// <summary>
        /// Возвращает и задает дисциплину математику.
        /// </summary>
        public bool Math { get { return _math; } set { _math = value; } }
        /// <summary>
        /// Возвращает и задает дисциплину программирование.
        /// </summary>
        public bool Programming { get { return _programming; } set { _programming = value; } }
        /// <summary>
        /// Возвращает и задает дисциплину проект.
        /// </summary>
        public bool Project { get { return _project; } set { _project = value; } }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="math">Математика.</param>
        /// <param name="programming">Программирование.</param>
        /// <param name="project">Проект.</param>
        public Discipline(bool math, bool programming, bool project)
        {
            Math = math;
            Programming = programming;
            Project = project;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        public Discipline()
        {
            
        }
    }
}
