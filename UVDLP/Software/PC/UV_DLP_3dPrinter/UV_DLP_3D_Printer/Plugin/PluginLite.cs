using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using UV_DLP_3D_Printer.GUI.CustomGUI;
using Ionic.Zip;
using System.IO;
using System.Windows.Forms;
namespace UV_DLP_3D_Printer.Plugin
{
    /// <summary>
    /// This class loads and saves to zip file that are the .pcw file format - Plugin Creation Workshop
    /// this file can contain the following:
    /// 1 guiconfig.xml file
    /// 0 or more machine config files
    /// 0 or moe slicing profile files
    /// 
    /// The slicing profiles will copy into the main /Profiles directory ONLY if they don't exist there already
    /// The machine profiles will copy into the main /Machine directory ONLY if they don't exist there already
    /// 
    /// 
    /// This is a 'lite' plugin desing for the following:
    /// 
    /// change/remove the splash screen
    /// change the about screen
    /// change the toolbar icon pictures
    /// remove toolbar icons
    /// remove program controls
    /// theme / color scheme
    /// create new toolbar buttons and bind them to gcode sequences
    /// 
    /// </summary>
    class PluginLite : IPlugin
    {
        private static PluginItem[] manifest =
        {
            new  PluginItem ("VendorName",ePlItemType.eString,0),
            new  PluginItem ("PluginName",ePlItemType.eString,0),
            new  PluginItem ("Version",ePlItemType.eString,0),
            new  PluginItem ("Description",ePlItemType.eString,0),
            new  PluginItem("Icon",ePlItemType.eImage,0),
            new  PluginItem("Splash",ePlItemType.eImage,0),
            new  PluginItem("About",ePlItemType.eImage,0),            
            new  PluginItem("VendorID",ePlItemType.eInt,0),
            new  PluginItem("GuiConfig",ePlItemType.eGuiConfig,0),
        };
        private IPluginHost m_host; // the host of this program is UVDLPapp
        public string m_filename; // the name of this zip file
        private static string m_Vendorname = "Envision Labs";        
        private static int m_VendorID = 0x1000; //
        private static string m_PluginName = "Envision Labs";
        private static string m_description = "Envision Labs Plugin";
        private static string version = "1.0.0.1";
        private static int m_licensed = 0; // locked to a vendor key (1 or 0)
        private GuiConfigDB m_guiconfig;
        private bool inited = false;

        public Bitmap GetImage(string name)
        {
            Bitmap bmp = null;
            //try to load a bitmap from the zip file
            try
            {
                using (ZipFile m_zip = ZipFile.Read(m_filename))
                {
                    string fname = name + ".png";
                    ZipEntry ze = m_zip[fname];
                    Stream stream = new MemoryStream();
                    ze.Extract(stream);
                    bmp = new Bitmap(stream);
                    if (bmp != null)
                        return bmp;
                }
            }
            catch (Exception)
            {
                DebugLogger.Instance().LogError("Image resource " + name + ".png error loading from plugin " + m_filename);
            }
            return bmp;
        }
        public GuiConfigDB GUIDB 
        {
            get { return m_guiconfig; }
            set { m_guiconfig = value; }
        }
        // this will set the plugin host
        public IPluginHost Host 
        {
            get { return m_host; }
            set { 
                m_host = value;
                Initialize();
            }
        } 
        // this function will return a manifest of plugin items
        public List<PluginItem> GetPluginItems 
        {
            get
            {
                List<PluginItem> items = new List<PluginItem>();
                items.AddRange(manifest);
                return items;
            }
        }

        public int GetInt(string name)
        {
            if (name.Equals("VendorID"))
                return m_VendorID;
            if (name.Equals("HasLicense"))
                return m_licensed;
            return -1;

        }
        public String GetString(string name)
        {
            if (name.Equals("VendorName"))
                return m_Vendorname;

            if (name.Equals("PluginName"))
                return m_PluginName;

            if (name.Equals("Description"))
                return m_description;

            if (name.Equals("Version"))
                return version;// Assembly.GetCallingAssembly().GetName().Version.ToString();

            if (name.Equals("GuiConfig")) 
            {
                // load from zip
                Stream guiconf = Utility.ReadFromZip(m_filename, "GuiConfig.xml");
                if (guiconf == null) //bail if it's not there.
                {
                    DebugLogger.Instance().LogError("No GuiConfig.xml found in plugin");
                    return "";
                }
                StreamReader streamReader = new StreamReader(guiconf);
                //get the text of the stream
                string sguiconf = streamReader.ReadToEnd();
                streamReader.Close();
                return sguiconf;
            }
            return "Unknown Name";
        }

        public UserControl GetControl(string name) 
        {
            return null; // no actual gui controls in here for now
        }
        //don't think we actually used this before.
        public byte[] GetBinary(string name) 
        {
            return null;
        }

        public void ExecuteFunction(string name) 
        {
        
        }
        public void ExecuteFunction(string name, object[] parms) 
        {
        
        }
        public bool SupportFunctionality(PluginFuctionality func) 
        {
            switch (func) 
            {
                case PluginFuctionality.CustomGUI: return true;
            }
            return false;
        }
        private void Initialize()
        {
            if (inited) // no re-initialization
                return;
            //load the guiconfigdb locally here to search / parse items
            inited = true;
        }
        public String Name 
        {
            get { return "Pro Plugin created"; }
        } // required NOT to be part of the string plugin items        
    }
}
