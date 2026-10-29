using System;

public class ImageProcessor
{
    public void ResizeImage(int width, int height)
    {
        if (width <= 0 || height <= 0)
        {
            Console.WriteLine("Ошибка: Размеры должны быть больше нуля.");
            return;
        }
        Console.WriteLine($"Новый размер изображения: {width}x{height}");
    }

    public void ResizeImage(int originalWidth, int originalHeight, double scaleFactor)
    {
        if (originalWidth <= 0 || originalHeight <= 0 || scaleFactor <= 0)
        {
            Console.WriteLine("Ошибка: Некорректные входные параметры.");
            return;
        }
        int newWidth = (int)(originalWidth * scaleFactor);
        int newHeight = (int)(originalHeight * scaleFactor);
        Console.WriteLine($"Масштабированный размер ({scaleFactor}x): {newWidth}x{newHeight}");
    }

    public void ResizeImage(int originalWidth, int originalHeight, int maxWidth, int maxHeight)
    {
        if (originalWidth <= 0 || originalHeight <= 0 || maxWidth <= 0 || maxHeight <= 0)
        {
            Console.WriteLine("Ошибка: Некорректные входные параметры.");
            return;
        }
        double ratioX = (double)maxWidth / originalWidth;
        double ratioY = (double)maxHeight / originalHeight;
        double ratio = Math.Min(ratioX, ratioY);

        int newWidth = (int)(originalWidth * ratio);
        int newHeight = (int)(originalHeight * ratio);
        Console.WriteLine($"Размер с сохранением пропорций в рамках {maxWidth}x{maxHeight}: {newWidth}x{newHeight}");
    }
}

class Program
{
    static void Main()
    {
        ImageProcessor processor = new ImageProcessor();
        processor.ResizeImage(800, 600);
        processor.ResizeImage(1920, 1080, 0.5);
        processor.ResizeImage(1920, 1080, 1024, 768);
    }
}
