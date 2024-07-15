namespace Inheritance.DataStructure;
public class Category : IComparable
{
    public string Product { get; set; } = string.Empty;
    public MessageType Type { get; set; }
    public MessageTopic Theme { get; set; }

    public Category(string Product, MessageType Type, MessageTopic Theme)
    {
        this.Product = Product;
        this.Type = Type;
        this.Theme = Theme;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Category other = (Category)obj;
        return Product == other.Product && Type == other.Type && Theme == other.Theme;
    }

    // Переопределение GetHashCode()
    public override int GetHashCode()
    {
        return HashCode.Combine(Product, Type, Theme);
    }
    public override string ToString()
    {
        return $"{Product}.{Type}.{Theme}";
    }

    // Реализация IComparable
    public int CompareTo(object? other)
    {
        if (other == null) 
            return 1;
        Category otherCategory = (Category)other;

        int productComparison = string.Compare(Product, otherCategory.Product, StringComparison.Ordinal);
        if (productComparison != 0) 
            return productComparison;

        int typeComparison = Type.CompareTo(otherCategory.Type);
        if (typeComparison != 0) 
            return typeComparison;

        return Theme.CompareTo(otherCategory.Theme);
    }

    // Операторы сравнения

    public static bool operator ==(Category left, Category right)
    {
        if (left.Equals(right))
            return true;
        return false;
    }

    public static bool operator !=(Category left, Category right)
    {
        return !(left == right);
    }

    public static bool operator <(Category left, Category right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator >(Category left, Category right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator <=(Category left, Category right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >=(Category left, Category right)
    {
        return left.CompareTo(right) >= 0;
    }
 
}


