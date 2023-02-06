using Npgsql;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 namespace DatabaseFinal
{
    public class Address
    {
        //instance variables
        private int addressID;
        private string line;
        private string city;
        private string state;
        private string zipcode;
        private string country = "";

        private static NpgsqlConnection _connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=;User Id=postgres;Password=;");

        //exceutes the database queries 
        private static DataTable GetConnection(string statement)
        {
            _connection.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = _connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = statement;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.Dispose();
            _connection.Close();
            return dt;
        }

        //overloaded constructor
        public Address(string line, string city, string state, string zipcode, string country)
        {
            SetLine(line);
            SetCity(city);
            SetState(state);
            SetZipCode(zipcode);
            SetCountry(country);
            Insert();
        }

        //overloaded constructor
        public Address(string line, string city, string state, string zipcode)
        {
            SetLine(line);
            SetCity(city);
            SetState(state);
            SetZipCode(zipcode);
            Insert();
        }

        //constructor creates object based on addressID found in database
        public Address(int addressID)
        {
            DataTable temp = SelectByAddressID(addressID);

            this.addressID = Convert.ToInt32(temp.Rows[0][0].ToString());
            this.line = temp.Rows[0][1].ToString();
            this.city = temp.Rows[0][2].ToString();
            this.state = temp.Rows[0][3].ToString();
            this.zipcode = temp.Rows[0][4].ToString();
            this.country = temp.Rows[0][5].ToString();
        }

        //sets line with validation
        public void SetLine(string line)
        {
            if (line.Length > 50 && line == null)
            {

                MessageBox.Show(line + " could not be added. Address lines must not be " +
                    "greater than 50 characters or have a null value. This address line has " +
                    "been renamed to Unknown.");
                line = "Unknown";
            }
            else
            {
                this.line = line.Trim();
            }

        }

        //sets city with validation
        public void SetCity(string city)
        {
            if (city.Length > 50 && city == null)
            {

                MessageBox.Show(city + " could not be added. Address cities must not be " +
                    "greater than 50 characters or have a null value. This address city has " +
                    "been renamed to Unknown.");
                city = "Unknown";
            }
            else
            {
                this.city = city.Trim();
            }
        }

        //sets state with validation
        public void SetState(string state)
        {
            if (state.Length > 50 && state == null)
            {

                MessageBox.Show(state + " could not be added. Address states must not be " +
                    "greater than 50 characters or have a null value. This address state has " +
                    "been renamed to Unknown.");
                state = "Unknown";
            }
            else
            {
                this.state = state.Trim();
            }
        }

        //sets zipcode with validation
        public void SetZipCode(string zipcode)
        {
            if (zipcode.Length > 10 && zipcode == null)
            {

                MessageBox.Show(zipcode + " could not be added. Address zipcodes must not be " +
                    "greater than 10 characters or have a null value. This address zipcode has " +
                    "been renamed to Unknown.");
                zipcode = "Unknown";
            }
            else
            {
                this.zipcode = zipcode.Trim();
            }
        }

        //sets country with validation
        public void SetCountry(string country)
        {
            if (country.Length > 50 && country == null)
            {

                MessageBox.Show(country + " could not be added. Address countries must not be " +
                    "greater than 50 characters or have a null value. This address country has " +
                    "been renamed to Unknown.");
                country = "Unknown";
            }
            else
            {
                this.country = country.Trim();
            }
        }
        
        //returns addressID
        public int GetAddressID()
        {
            return this.addressID;
        }
        
        //returns line
        public string GetLine()
        {
            return this.line;
        }
        
        //returns city
        public string GetCity()
        {
            return this.city;
        }
        
        //returns state
        public string GetState()
        {
            return this.state;
        }
        
        //returns zipcode
        public string GetZipCode()
        {
            return this.zipcode;
        }
        
        //returns country
        public string GetCountry()
        {
            return this.country;
        }
        
        //ToString
        public override string ToString()
        {
            return this.GetLine() + ", " + this.GetCity() + ", " + this.GetState() +
                " " + this.GetZipCode() + " " + this.GetCountry();
        }
        
        //inserts the current object into the database and calls SelectAddressID
        //to assign an addressID to the current object
        public void Insert()
        {
            if (this.country.Equals(""))
            {
                GetConnection("INSERT INTO address(line, city, stat, zipcode) " +
                    "VALUES('" + this.line + "', '" + this.city + "', '" + this.state + "', '" + this.zipcode + "')");
                this.country = "United States"; //database defaults to United States upon null country
            }
            else
            {
                GetConnection("INSERT INTO address(line, city, stat, zipcode, country) " +
                    "VALUES('" + this.line + "', '" + this.city + "', '" + this.state + "', '" +
                    this.zipcode + "', '" + this.country + "')");
            }
            this.addressID = this.SelectAddressID(); //pulls the address from the database to get addressID
        }

        //selects the address serial generated by the database
        private int SelectAddressID()
        {
            return Convert.ToInt32(GetConnection("SELECT addressID FROM address WHERE line = '" + 
                this.line + "' AND city = '" + this.city + "' AND stat = '" + 
                this.state + "' AND zipcode = '" + this.zipcode + "' AND country = '" + 
                this.country + "'").Rows[0][0].ToString());
        }

        //selects all entries of address in the database
        public static DataTable SelectAll()
        {
            return GetConnection("SELECT * FROM address");
        }

        //selects a table of addresses by their ID in the database
        public static DataTable SelectByAddressID(int addressID)
        {
            return GetConnection("SELECT * FROM address WHERE addressID = " + addressID);
        }

        //selects a table of addresses by their line in the database
        public static DataTable SelectByLine(string line)
        {
            return GetConnection("SELECT * FROM address WHERE line = '" + line + "'");
        }

        //selects a table of addresses by their city in the database
        public static DataTable SelectByCity(string city)
        {
            return GetConnection("SELECT * FROM address WHERE city = '" + city + "'");
        }

        //selects a table of addresses by their state in the database
        public static DataTable SelectByState(string state)
        {
            return GetConnection("SELECT * FROM address WHERE stat = '" + state + "'");
        }

        //selects a table of addresses by their zipcode in the database
        public static DataTable SelectByZipCode(string zipcode)
        {
            return GetConnection("SELECT * FROM address WHERE zipcode = '" + zipcode + "'");
        }

        //selects a table of addresses by their country in the database
        public static DataTable SelectByCountry(string country)
        {
            return GetConnection("SELECT * FROM address WHERE country = '" + country + "'");
        }

        //deletes the current object from the database
        public void Delete()
        {
            GetConnection("DELETE FROM address WHERE addressID = '" + this.addressID + "'");
        }

        //updates the current object in the database
        public void Update()
        {
            GetConnection("UPDATE address SET line = '" + this.line + 
                "', city = '" + this.city + "', stat = '" + this.state + 
                "', zipcode = '" + this.zipcode + "', country ='" + this.country + "' " +
                "WHERE addressID = " + this.addressID);
        }

    }
}
