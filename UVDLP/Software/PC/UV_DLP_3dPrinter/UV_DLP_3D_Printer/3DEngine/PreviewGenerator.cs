using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine3D;
using UV_DLP_3D_Printer;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using UV_DLP_3D_Printer._3DEngine;
using System.Drawing;
namespace UV_DLP_3D_Printer._3DEngine
{
    /// <summary>
    /// This class can take an Object3d, and render it into an off-screen buffer
    /// This class should be able to automatically set up the camera as well to a relative distance away
    /// these previews are then used in the Load file dialog, and exported into the /preview directory
    /// </summary>
    public class PreviewGenerator
    {
        public PreviewGenerator() 
        {
        
        }
        /// <summary>
        /// This function will take an object, move the camera a distance away and generate the preview
        /// </summary>
        /// <param name="xsize"></param>
        /// <param name="ysize"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public Bitmap GeneratePreview(int xsize, int ysize, Object3d obj) 
        {
            // taken from http://www.opentk.com/doc/graphics/frame-buffer-objects
            // more good examples here: http://www.opentk.com/node/1642?page=1
            int FboWidth = xsize;
            int FboHeight = ysize;

            uint FboHandle;
            uint ColorTexture;
            uint DepthRenderbuffer;
            GLCamera previewcamera = new GLCamera();

            // Create Color Texture
            GL.GenTextures(1, out ColorTexture);
            GL.BindTexture(TextureTarget.Texture2D, ColorTexture);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Nearest);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Clamp);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Clamp);
            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba8, FboWidth, FboHeight, 0, PixelFormat.Rgba, PixelType.UnsignedByte, IntPtr.Zero);

            // test for GL Error here (might be unsupported format)

            GL.BindTexture(TextureTarget.Texture2D, 0); // prevent feedback, reading and writing to the same image is a bad idea

            // Create Depth Renderbuffer
            GL.Ext.GenRenderbuffers(1, out DepthRenderbuffer);
            GL.Ext.BindRenderbuffer(RenderbufferTarget.RenderbufferExt, DepthRenderbuffer);
            GL.Ext.RenderbufferStorage(RenderbufferTarget.RenderbufferExt, (RenderbufferStorage)All.DepthComponent32, FboWidth, FboHeight);

            // test for GL Error here (might be unsupported format)

            // Create a FBO and attach the textures
            GL.Ext.GenFramebuffers(1, out FboHandle);
            GL.Ext.BindFramebuffer(FramebufferTarget.FramebufferExt, FboHandle);
            GL.Ext.FramebufferTexture2D(FramebufferTarget.FramebufferExt, FramebufferAttachment.ColorAttachment0Ext, TextureTarget.Texture2D, ColorTexture, 0);
            GL.Ext.FramebufferRenderbuffer(FramebufferTarget.FramebufferExt, FramebufferAttachment.DepthAttachmentExt, RenderbufferTarget.RenderbufferExt, DepthRenderbuffer);

            // now GL.Ext.CheckFramebufferStatus( FramebufferTarget.FramebufferExt ) can be called, check the end of this page for a snippet.

            // since there's only 1 Color buffer attached this is not explicitly required
            GL.DrawBuffer((DrawBufferMode)FramebufferAttachment.ColorAttachment0Ext);

            GL.PushAttrib(AttribMask.ViewportBit); // stores GL.Viewport() parameters
            GL.Viewport(0, 0, FboWidth, FboHeight);

            // render whatever your heart desires, when done ...
            // clear buffer
            //GL.ClearColor(Color.White);
            // clear the screen, to make it very obvious what the clear affected. only the FBO, not the real framebuffer
            GL.ClearColor(1.0f, 1.0f, 1.0f, 1.0f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit );
            //set up camera
           // previewcamera.UpdateView();
            previewcamera.ResetView(0, -200, 0, 20, 20);
            previewcamera.SetViewGL();
            //render scene
            obj.RenderGL(false, false, false, Color.Green);
            //copy the framebuffer to a bitmap
            Bitmap bmppreview = GetBitmap(xsize, ysize);
            GL.PopAttrib(); // restores GL.Viewport() parameters
            GL.Ext.BindFramebuffer(FramebufferTarget.FramebufferExt, 0); // return to visible framebuffer
            GL.DrawBuffer(DrawBufferMode.Back);
            return bmppreview;
        }


        private Bitmap GetBitmap(int width, int height)
        {
            System.Drawing.Bitmap bitmap = null;

            bitmap = new System.Drawing.Bitmap(width, height);
            System.Drawing.Imaging.BitmapData data = bitmap.LockBits(new System.Drawing.Rectangle(0, 0, width, height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            //GL.ReadBuffer(ReadBufferMode.ColorAttachment0);
            GL.ReadBuffer(ReadBufferMode.ColorAttachment0);
            
            GL.ReadPixels(0, 0, width, height, PixelFormat.Bgr, PixelType.UnsignedByte, data.Scan0);
            bitmap.UnlockBits(data);
            bitmap.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipY);
            return bitmap;
        }
    }
}
