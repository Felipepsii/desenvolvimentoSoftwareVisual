using System;
using System.IO;
using System.Collections.Generic;


namespace Aula03
{
    class Usuario
    {

           static int UID = 0;
        int id;

        string username;
        string hash;

        
        public Usuario(string u, string p){

            id = getUID();
            SetUsername(u);
            ApplyHash(p);   
        }

        static int getUID(){
            UID++;
            return UID;
        }

        void ApplyHash(string password){
            
            //TODO aplicar hash (ver na aula passada 25/08)
            hash = password;
        }

        public string GetUsername(){
            return username;
        }

        public string GetHash(){
            return hash;
        }

        public void SetUsername(string u){
            username = u;
        }

                public string Serialize(){
            return id + "," + username + "," + hash;
        }
    }

    class UserBase{

        string filename;
        List<Usuario> usuarios;

        public UserBase(String f)
        {
            usuarios = new List<Usuario>();
            filename = f;
            LoadUsers();
        } 

        void LoadUsers(){
         //   TODO
        }

        public void AddUser(Usuario u){
            usuarios.Add(u);
        }

        public void Save(){
            string output = "";
            foreach(Usuario u in usuarios){
            output += u.Serialize()+ "\n";

            }
            File.WriteAllText(filename,output);
        }
    }



 


}
