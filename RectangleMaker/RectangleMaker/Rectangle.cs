class Rectangle
{
    //Backing Fields
    private int _width;
    private int _length;

    //Property Fields
    public int width { get => this._width; set => this._width = value; }
    public int length { get => this._length; set => this._length = value; }

    public Rectangle(int w, int l)
    {
        _width = w;
        _length = l;
    }
}