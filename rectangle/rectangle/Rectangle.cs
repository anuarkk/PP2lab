namespace rectangle
{
    class Rectangle
    {
        private int a;
        private int b;
        private int perimeter;
        private int area;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
            find_Perimeter();
            find_Area();


        }
        public void find_Perimeter()
        {
            perimeter = a * 2 + b * 2;

        }
        public void find_Area()
        {
            area = a * b;
        }
        public override string ToString()
        {
            return "Perimeter = " + perimeter + "\narea = " + area;
        }
    }
}