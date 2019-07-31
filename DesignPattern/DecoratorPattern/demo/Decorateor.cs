using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern.demo
{
    /// <summary>
    /// 可以动态添加新功能的接口
    /// </summary>
    public interface IDecoratable
    {
        /// <summary>
        /// 添加并运行新功能
        /// </summary>
        void Decorate();
    }

    public abstract class Camera : IDecoratable
    {
        /// <summary>
        /// 拍照
        /// </summary>
        public abstract void TakePhoto();

        /// <summary>
        /// 实现接口中定义的新功能
        /// </summary>
        public void Decorate()
        {
            //转化为相机自身的功能：拍照 
            this.TakePhoto();
        }
    }

    public class Canon500D : Camera
    {
        public override void TakePhoto()
        {
            Console.WriteLine("500D拍照 ");
        }
    }

    /// <summary>
    /// 所有的动态添加的功能的抽象
    /// </summary>
    public abstract class Decorator:IDecoratable
    {
        /// <summary>
        /// 这个功能去添加的对象
        /// </summary>
        public IDecoratable ObjectToDecorate { get; set; }

        public virtual void Decorate()
        {
            if(this.ObjectToDecorate != null)
            {
                this.ObjectToDecorate.Decorate();
            }
        }

        public Decorator Decorate(Decorator objectToDecorate)
        {
            this.ObjectToDecorate = objectToDecorate;
            return objectToDecorate;
        }

        public void Decorate(IDecoratable objectToDecorate)
        {
            this.ObjectToDecorate = objectToDecorate;
        }
    }

    /// <summary>
    /// 三脚架
    /// </summary>
    public class Tripod:Decorator
    {
        public override void Decorate()
        {
            Console.WriteLine("树立三脚架，稳定相机");
            base.Decorate();
        }  
    }

    /// <summary>
    /// 闪光灯
    /// </summary>
    public class FlashLamp:Decorator
    {
        public override void Decorate()
        {
            Console.WriteLine("闪光灯充电并闪光");
            base.Decorate();
        }
    }

    /// <summary>
    /// 镜头
    /// </summary>
    public class Lens:Decorator 
    {
        public override void Decorate()
        {
            Console.WriteLine("安装镜头，并调整焦距和光圈");
            base.Decorate();
        }
    }
}