using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace TumbnailDotnet
{
    public partial class MainForm : Form
    {
        public string  Va = ConfigurationManager.AppSettings["dbPicture"];
        public event ThumbnailImageEventHandler OnImageSizeChanged;

        private ThumbnailController m_Controller;

        private ImageDialog m_ImageDialog;

        private ImageViewer m_ActiveImageViewer;

        private int ImageSize
        {
            get
            {
                return (64 * (this.trackBarSize.Value + 1));
            }
        }

        public MainForm()
        {
            InitializeComponent();

            this.buttonCancel.Enabled = false;

            m_ImageDialog = new ImageDialog();

            m_AddImageDelegate = new DelegateAddImage(this.AddImage);

            m_Controller = new ThumbnailController();
            m_Controller.OnStart += new ThumbnailControllerEventHandler(m_Controller_OnStart);
            m_Controller.OnAdd += new ThumbnailControllerEventHandler(m_Controller_OnAdd);
            m_Controller.OnEnd += new ThumbnailControllerEventHandler(m_Controller_OnEnd);
        }

        private void buttonBrowseFolder_Click(object sender, EventArgs e)
        {
            if (CmbImagePath.Text == "")
            { MessageBox.Show("���� ������ "); }
            else
            {
                this.AddFolder();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.m_Controller.CancelScanning = true;
        }

        private void AddFolder()
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            // dlg.Description = @"Choose folder path";
            //if (dlg.ShowDialog() == DialogResult.OK)
            // {
            //  dlg.SelectedPath = AppDomain.CurrentDomain.BaseDirectory+"\\Image_Path\\Patient";
            this.flowLayoutPanelMain.Controls.Clear();

            m_Controller.AddFolder(CmbImagePath.Text);
            //MessageBox.Show(CmbImagePath.Text);
            this.buttonCancel.Enabled = true;
            this.buttonBrowseFolder.Enabled = false;




        } 

        private void m_Controller_OnStart(object sender, ThumbnailControllerEventArgs e)
        {

        }

        private void m_Controller_OnAdd(object sender, ThumbnailControllerEventArgs e)
        {
            this.AddImage(e.ImageFilename);
            this.Invalidate();
        }

        private void m_Controller_OnEnd(object sender, ThumbnailControllerEventArgs e)
        {
            // thread safe
            if (this.InvokeRequired)
            {
                this.Invoke(new ThumbnailControllerEventHandler(m_Controller_OnEnd), sender , e);
            }
            else
            {
                this.buttonCancel.Enabled = false;
                this.buttonBrowseFolder.Enabled = true;
            }
        }

        delegate void DelegateAddImage(string imageFilename);
        private DelegateAddImage m_AddImageDelegate;

        private void AddImage(string imageFilename)
        {
            // thread safe
            if (this.InvokeRequired)
            {
                this.Invoke(m_AddImageDelegate, imageFilename);
            }
            else
            {
                int size = ImageSize;

                ImageViewer imageViewer = new ImageViewer();
                imageViewer.Dock = DockStyle.Bottom;
                imageViewer.LoadImage(imageFilename, 256, 256);
                imageViewer.Width = size;
                imageViewer.Height = size;
                imageViewer.IsThumbnail = true;
                imageViewer.MouseClick += new MouseEventHandler(imageViewer_MouseClick);

                this.OnImageSizeChanged += new ThumbnailImageEventHandler(imageViewer.ImageSizeChanged);

                this.flowLayoutPanelMain.Controls.Add(imageViewer);
            }
        }

        private void imageViewer_MouseClick(object sender, MouseEventArgs e)
        {
            if (m_ActiveImageViewer != null)
            {
                m_ActiveImageViewer.IsActive = false;
            }

            m_ActiveImageViewer = (ImageViewer)sender;
            m_ActiveImageViewer.IsActive = true;

            if (m_ImageDialog.IsDisposed) m_ImageDialog = new ImageDialog();
            if (!m_ImageDialog.Visible) m_ImageDialog.Show();

            m_ImageDialog.SetImage(m_ActiveImageViewer.ImageLocation);
        }

        private void trackBarSize_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.OnImageSizeChanged(this, new ThumbnailImageEventArgs(ImageSize));
            }
            catch { };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           


               if (Va == "")
               {
                   // MessageBox.Show(@"\\" + ConfigurationManager.AppSettings["dbServerName"] + @"\" + AppDomain.CurrentDomain.BaseDirectory + Image_Path).ToString();
                   
                   
                   //i.Save(Va + AppDomain.CurrentDomain.BaseDirectory + Image_Path);
            CmbImagePath.Items.Add(Va+ AppDomain.CurrentDomain.BaseDirectory + @"Image_Path\Patient\");
            CmbImagePath.Items.Add(Va+AppDomain.CurrentDomain.BaseDirectory + @"Image_Path\X_Ray\");
            CmbImagePath.Items.Add(Va+AppDomain.CurrentDomain.BaseDirectory + @"Image_Path\Logo\");
            CmbImagePath.Items.Add(Va+AppDomain.CurrentDomain.BaseDirectory + @"Image_Path\User\");

                   //SP
               }
               else
               {
                   string SQ = @"\SQLEXPRESS";
                   string s = Va.Trim(SQ.ToCharArray());

            CmbImagePath.Items.Add(@"\\" + s + @"\" + @"Image_Path\Patient\");
            CmbImagePath.Items.Add(@"\\" + s + @"\" +@"Image_Path\X_Ray\");
            CmbImagePath.Items.Add(@"\\" + s + @"\" + @"Image_Path\Logo\");
            CmbImagePath.Items.Add(@"\\" + s + @"\" + @"Image_Path\User\");

                  
               }
           //}
        }

        
    }

    public class ThumbnailImageEventArgs : EventArgs
    {
        public ThumbnailImageEventArgs(int size)
        {
            this.Size = size;
        }

        public int Size;
    }

    public delegate void ThumbnailImageEventHandler(object sender, ThumbnailImageEventArgs e);

}