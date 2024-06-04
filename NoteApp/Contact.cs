using NoteApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// Класс контакта.
    /// </summary>
    public class Contact : IComparable<Contact>, ICloneable
    {
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Эл.почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// ID vk контакта.
        /// </summary>
        private string _vkID;

        /// <summary>
        /// День рождения контакта.
        /// </summary>
        private DateTime _birthday;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private PhoneNumber _phone;

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Contact()
        {
            Phone = new PhoneNumber();
        }

        public string PhoneNumber { get; set; }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="surname"> Фамилия.</param>
        /// <param name="name"> Имя. </param>
        /// <param name="email"> Эл.почта. </param>
        /// <param name="vkId"> vkID. </param>
        /// <param name="birthday"> День рождения. </param>
        /// <param name="phone"> Номер телефона. </param>
        public Contact(
      string surname,
      string name,
      string email,
      string vkId,
      DateTime birthday,
      string phone)
        {
            Surname = surname;
            Name = name;
            Email = email;
            VkID = vkId;
            Birthday = birthday;
            Phone = new PhoneNumber(phone);
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                Validator.CheckMaxLength(value, 50);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает эл.почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                Validator.CheckMaxLength(value, 50);
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.CheckMaxLength(value, 50);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер контакта.
        /// </summary>
        public PhoneNumber Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }

        /// <summary>
        /// Возвращает и задает vkID контакта.
        /// </summary>
        public string VkID
        {
            get
            {
                return _vkID;
            }
            set
            {
                Validator.CheckMaxLength(value, 15);
                _vkID = value;
            }
        }

        /// <summary>
        /// Возвращает и задает день рождение контакта.
        /// </summary>
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                Validator.CheckBirthday(value);
                _birthday = value;
            }
        }

        /// <summary>
        /// Метод создания клона объекта контакта.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Contact
                (
                Surname,
                Name,
                Email,
                VkID,
                Birthday,
                Phone.Number
                );
        }

        /// <summary>
        /// Метод сравнения 2 массивов для сортировки.
        /// </summary>
        /// <param name="other">Объект сравнения.</param>
        /// <returns>Меньше нуля. Значит, текущий объект должен находиться перед объектом, 
        /// который передается в качестве параметра
        /// Равен нулю.Значит, оба объекта равны
        ///Больше нуля.Значит, текущий объект должен находиться после объекта, 
        ///передаваемого в качестве параметра</returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(Contact other)
        {
            if (other is Contact)
            {
                return Surname.CompareTo(other.Surname);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// Переопределнный метод сравнения контактов.
        /// </summary>
        /// <param name="obj">Объект сравнения.</param>
        /// <returns>True, если все поля совпадают по значению.</returns>
        public override bool Equals(object obj)
        {
            Contact contact;
            if (obj is Contact)
            {
                contact = (Contact)obj;
            }
            else
            {
                return false;
            }
            return (
                this.Surname == contact.Surname &&
                this.Name == contact.Name &&
                this.Email == contact.Email &&
                this.Phone.Number == contact.Phone.Number &&
                this.VkID == contact.VkID &&
                this.Birthday == contact.Birthday);
        }
    }
}
