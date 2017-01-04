using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.OleDb;
using System.Net;
using System.Net.Sockets;

namespace efControls
{
    /// <summary>
    /// Class SqlServerInfo <p/>
    /// Provides information about a MS SQL server instance.
    /// </summary>
    /// <example><pre>
    /// SqlServerInfo[] servs = SqlServerInfo.Seek();
    /// foreach(SqlServerInfo inst in servs)
    /// {
    /// Console.WriteLine("Server: {0}, InstanceName: {1}, Version: {2}",
    /// serv.ServerName, serv.InstanceName, serv.Version);
    /// foreach(string db in serv.Catalogs)
    /// {
    /// Console.WriteLine("      Database: {0}", db);
    /// }
    /// }
    /// </pre></example>
    /// <remarks>
    /// Copyright  2005, James M. Curran. <br/>
    /// First published on CodeProject.com, Nov 2005 <br/>
    /// May be used freely.
    /// </remarks>
    public class SqlServerInfo
    {
        private string oServerName;
        private string oInstanceName;
        private bool oIsClustered;
        private string oVersion;
        private int otcpPort;
        private string oNp;
        private string oRpc;
        private IPAddress oIP;
        private StringCollection oCatalogs;
        private string oUserId;
        private string oPassword;
        private bool oIntegratedSecurity = true;
        private int oTimeOut = 2;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerInfo"/> class.
        /// </summary>
        private SqlServerInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerInfo"/> class.
        /// </summary>
        /// <param name="ip">The ip.</param>
        /// <param name="info">The info.</param>
        public SqlServerInfo(IPAddress ip, byte[] info)
            : this(ip, System.Text.ASCIIEncoding.ASCII.GetString(info, 3, BitConverter.ToInt16(info, 1)))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerInfo"/> class.
        /// </summary>
        /// <param name="ip">The ip address.</param>
        /// <param name="info">The info.</param>
        public SqlServerInfo(IPAddress ip, string info)
        {
            oIP = ip;
            var nvs = info.Split(';');
            for (var i = 0; i < nvs.Length; i += 2)
            {
                switch (nvs[i].ToLower())
                {
                    case "servername":
                        oServerName = nvs[i + 1];
                        break;

                    case "instancename":
                        oInstanceName = nvs[i + 1];
                        break;

                    case "isclustered":
                        oIsClustered = (nvs[i + 1].ToLower() == "yes");
                        break;

                    case "version":
                        oVersion = nvs[i + 1];
                        break;

                    case "tcp":
                        otcpPort = int.Parse(nvs[i + 1]);
                        break;

                    case "np":
                        oNp = nvs[i + 1];
                        break;

                    case "rpc":
                        oRpc = nvs[i + 1];
                        break;
                }
            }
        }

        /// <summary>
        /// Gets the IP address.
        /// </summary>
        /// <value>The address.</value>
        /// <remarks>Presently, this is not implemented and will always return null,</remarks>
        public IPAddress Address
        {
            get
            {
                return oIP;
            }
        }

        /// <summary>
        /// Gets the name of the server.
        /// </summary>
        /// <value>The name of the server.</value>
        public string ServerName
        {
            get
            {
                return oServerName;
            }
        }

        /// <summary>
        /// Gets the name of the instance.
        /// </summary>
        /// <value>The name of the instance.</value>
        public string InstanceName
        {
            get
            {
                return oInstanceName;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is clustered.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if this instance is clustered; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsClustered
        {
            get
            {
                return oIsClustered;
            }
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        public string Version
        {
            get
            {
                return oVersion;
            }
        }

        /// <summary>
        /// Gets the TCP port.
        /// </summary>
        /// <value>The TCP port.</value>
        public int TcpPort
        {
            get
            {
                return otcpPort;
            }
        }

        /// <summary>
        /// Gets the named pipe.
        /// </summary>
        /// <value>The named pipe.</value>
        public string NamedPipe
        {
            get
            {
                return oNp;
            }
        }

        /// <summary>
        /// Gets the catalogs.
        /// </summary>
        /// <value>The catalogs.</value>
        public StringCollection Catalogs
        {
            get
            {
                if (oCatalogs == null)
                {
                    oCatalogs = GetCatalogs();
                }
                return oCatalogs;
            }
        }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>The user id.</value>
        public string UserId
        {
            get
            {
                return oUserId;
            }
            set
            {
                oUserId = value;
                oIntegratedSecurity = false;
            }
        }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password
        {
            get
            {
                return oPassword;
            }
            set
            {
                oPassword = value;
                oIntegratedSecurity = false;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [integrated security].
        /// </summary>
        /// <value>
        /// <see langword="true"/> if [integrated security]; otherwise, <see langword="false"/>.
        /// </value>
        public bool IntegratedSecurity
        {
            get
            {
                return oIntegratedSecurity;
            }
            set
            {
                oIntegratedSecurity = value;
            }
        }

        /// <summary>
        /// Gets or sets the time out.
        /// </summary>
        /// <value>The time out.</value>
        public int TimeOut
        {
            get
            {
                return oTimeOut;
            }
            set
            {
                oTimeOut = value;
            }
        }

        /// <summary>
        /// Tests the connection.
        /// </summary>
        /// <returns></returns>
        public bool TestConnection()
        {
            var conn = GetConnection();
            var success = false;
            try
            {
                conn.Open();
                conn.Close();
                success = true;
            }
            catch
            {
            }
            return success;
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            if (InstanceName == null || InstanceName == "MSSQLSERVER")
            {
                return ServerName;
            }
            else
            {
                return ServerName + "\\" + InstanceName;
            }
        }

        private StringCollection GetCatalogs()
        {
            var catalogs = new StringCollection();
            try
            {
                var myConnection = GetConnection();
                myConnection.Open();
                var schemaTable = myConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Catalogs,
                    null);
                myConnection.Close();
                foreach (DataRow dr in schemaTable.Rows)
                {
                    catalogs.Add(dr[0] as string);
                }
            }
            catch (Exception)
            {
            }
            return catalogs;
        }

        private OleDbConnection GetConnection()
        {
            var myConnString = IntegratedSecurity ?
                String.Format("Provider=SQLOLEDB;Data Source={0};Integrated Security=SSPI;Connect Timeout={1}", this, TimeOut)
            : String.Format("Provider=SQLOLEDB;Data Source={0};User Id={1};Password={2};Connect Timeout={3}",
                this, UserId, Password, TimeOut);

            return new OleDbConnection(myConnString);
        }

        /// <summary>
        /// Seeks SQL servers on this network.
        /// </summary>
        /// <returns>An array of SqlServerInfo objects describing Sql Servers on this network</returns>
        public static SqlServerInfo[] Seek()
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 3000);

            var servers = new ArrayList();
            try
            {
                var msg = new byte[] { 0x02 };
                var ep = new IPEndPoint(IPAddress.Broadcast, 1434);
                socket.SendTo(msg, ep);

                var cnt = 0;
                var bytBuffer = new byte[1024];
                do
                {
                    cnt = socket.Receive(bytBuffer);
                    servers.Add(new SqlServerInfo(null, bytBuffer));
                    socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 300);
                }
                while (cnt != 0);
            }
            catch (SocketException socex)
            {
                const int WSAETIMEDOUT = 10060;
                const int WSAEHOSTUNREACH = 10065;

                if (socex.ErrorCode == WSAETIMEDOUT || socex.ErrorCode == WSAEHOSTUNREACH)
                {
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                socket.Close();
            }

            var aServers = new SqlServerInfo[servers.Count];
            servers.CopyTo(aServers);
            return aServers;
        }
    }
}
