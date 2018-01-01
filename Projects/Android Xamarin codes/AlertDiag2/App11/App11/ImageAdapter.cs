using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App11
{
    public class ImageAdapter : BaseAdapter
    {
        Context cont;

        int[] imageArrayList = {
        Resource.Drawable.img1,
        Resource.Drawable.img2,
        Resource.Drawable.img3,
        Resource.Drawable.img4,
        Resource.Drawable.img5,
        Resource.Drawable.img6,
        Resource.Drawable.img7,
        };
        public ImageAdapter(Context ct)
        {
            cont = ct;
        }

        public override int Count
        {
            get
            {
                return imageArrayList.Length;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;
            if (convertView == null)
            {
                imageView = new ImageView(cont);
                imageView.LayoutParameters = new GridView.LayoutParams(100, 100);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                imageView.SetPadding(8, 8, 8, 8);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(imageArrayList[position]);
            return imageView;

        }
    }
}