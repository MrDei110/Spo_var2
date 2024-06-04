﻿using NoteApp;

namespace NoteApp.Service
{
    /// <summary>
    /// Класс для передачи объекта контакта между формами.
    /// </summary>
    public static class TransferContact
    {
        /// <summary>
        /// Задает и возвращает контакт между формами.
        /// </summary>
        public static Contact Data { get; set; }
    }
}