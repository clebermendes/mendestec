using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Business
{
    public class SessionRN
    {
        private static SessionRN instance = null;

        private Hashtable session = null;

        private static int login = 0;

        private SessionRN()
        {
            this.session = new Hashtable();
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns></returns>
        public static SessionRN getInstance()
        {
            if (instance == null)
            {
                instance = new SessionRN();
            }
            login++;
            return instance;
        }

        /// <summary>
        /// Removes the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        public void remove(String key)
        {
            this.session.Remove(key);
        }

        public void add(String key, Object value)
        {
            if (this.session.ContainsKey(key))
            {
                this.remove(key);
            }
            this.session.Add(key, value);
        }

        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public Object get(String key)
        {
            return this.session[key];
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void clear()
        {
            this.session.Clear();
        }

        public static int getLogin()
        {
            return login;
        }

    }
}
