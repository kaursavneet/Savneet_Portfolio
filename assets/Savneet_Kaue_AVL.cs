using System;

// COSC 286 – Balanced Binary Trees
// Student: Savneet Kaur
// Assignment: AVL Tree

interface IBinaryTree
{
    int Count();
    bool Contains(int value);
    void PrintInOrder();
    void Clear();
}

interface IBalancedBinaryTree : IBinaryTree
{
    void Add(int value);
    int Height();
    bool IsValid();
}

class AvlTree : IBalancedBinaryTree
{
    private class Node
    {
        public int Value;
        public Node? Left;
        public Node? Right;
        public int Height;

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
            Height = 1;
        }
    }

    private Node? root;

    // Add a value to the AVL tree
    public void Add(int value)
    {
        root = Insert(root, value);
    }

    // Insert a value and rebalance the tree if necessary
    private Node Insert(Node? node, int value)
    {
        // Normal BST insertion
        if (node == null)
        {
            return new Node(value);
        }

        if (value < node.Value)
        {
            node.Left = Insert(node.Left, value);
        }
        else if (value > node.Value)
        {
            node.Right = Insert(node.Right, value);
        }
        else
        {
            // Duplicate values are not added
            return node;
        }

        // Update the height of this node
        node.Height = 1 + Math.Max(GetHeight(node.Left),
                                   GetHeight(node.Right));

        // Calculate balance factor
        int balance = GetBalance(node);

        // LL Case
        if (balance > 1 && value < node.Left!.Value)
        {
            return RotateRight(node);
        }

        // RR Case
        if (balance < -1 && value > node.Right!.Value)
        {
            return RotateLeft(node);
        }

        // LR Case
        if (balance > 1 && value > node.Left!.Value)
        {
            node.Left = RotateLeft(node.Left);
            return RotateRight(node);
        }

        // RL Case
        if (balance < -1 && value < node.Right!.Value)
        {
            node.Right = RotateRight(node.Right);
            return RotateLeft(node);
        }

        return node;
    }

    // Right rotation
    private Node RotateRight(Node y)
    {
        Node x = y.Left!;
        Node? temp = x.Right;

        x.Right = y;
        y.Left = temp;

        y.Height = 1 + Math.Max(GetHeight(y.Left),
                                GetHeight(y.Right));

        x.Height = 1 + Math.Max(GetHeight(x.Left),
                                GetHeight(x.Right));

        return x;
    }

    // Left rotation
    private Node RotateLeft(Node x)
    {
        Node y = x.Right!;
        Node? temp = y.Left;

        y.Left = x;
        x.Right = temp;

        x.Height = 1 + Math.Max(GetHeight(x.Left),
                                GetHeight(x.Right));

        y.Height = 1 + Math.Max(GetHeight(y.Left),
                                GetHeight(y.Right));

        return y;
    }

    // Return the height of a node
    private int GetHeight(Node? node)
    {
        if (node == null)
        {
            return 0;
        }

        return node.Height;
    }

    // Calculate balance factor
    private int GetBalance(Node? node)
    {
        if (node == null)
        {
            return 0;
        }

        return GetHeight(node.Left) - GetHeight(node.Right);
    }

    // Check whether a value exists
    public bool Contains(int value)
    {
        Node? current = root;

        while (current != null)
        {
            if (value == current.Value)
            {
                return true;
            }

            if (value < current.Value)
            {
                current = current.Left;
            }
            else
            {
                current = current.Right;
            }
        }

        return false;
    }

    // Count all nodes
    public int Count()
    {
        return CountNodes(root);
    }

    private int CountNodes(Node? node)
    {
        if (node == null)
        {
            return 0;
        }

        return 1 + CountNodes(node.Left) + CountNodes(node.Right);
    }

    // Return the height of the entire tree
    public int Height()
    {
        return GetHeight(root);
    }

    // Print values using inorder traversal
    public void PrintInOrder()
    {
        PrintInOrder(root);
        Console.WriteLine();
    }

    private void PrintInOrder(Node? node)
    {
        if (node == null)
        {
            return;
        }

        PrintInOrder(node.Left);
        Console.Write(node.Value + " ");
        PrintInOrder(node.Right);
    }

    // Remove all nodes from the tree
    public void Clear()
    {
        root = null;
    }

    // Check whether the entire tree is a valid AVL tree
    public bool IsValid()
    {
        return Validate(root, null, null);
    }

    private bool Validate(Node? node, int? min, int? max)
    {
        if (node == null)
        {
            return true;
        }

        // Check BST ordering
        if (min.HasValue && node.Value <= min.Value)
        {
            return false;
        }

        if (max.HasValue && node.Value >= max.Value)
        {
            return false;
        }

        // Check AVL balance factor
        int balance = GetBalance(node);

        if (balance < -1 || balance > 1)
        {
            return false;
        }

        // Check left and right subtrees
        return Validate(node.Left, min, node.Value) &&
               Validate(node.Right, node.Value, max);
    }
}

class Program
{
    static void Main()
    {
        // Part D - Test Your AVL Tree

        IBalancedBinaryTree tree = new AvlTree();

        int[] values = { 50, 30, 70, 20, 40, 10 };

        foreach (int value in values)
        {
            tree.Add(value);
        }

        Console.Write("Inorder: ");
        tree.PrintInOrder();

        Console.WriteLine("Count: " + tree.Count());
        Console.WriteLine("Height: " + tree.Height());
        Console.WriteLine("Contains 40: " + tree.Contains(40));
        Console.WriteLine("Contains 99: " + tree.Contains(99));
        Console.WriteLine("Valid AVL: " + tree.IsValid());


        // Part E - Duplicate Value Test

tree.Add(40);

Console.WriteLine("Count after duplicate: " + tree.Count());

Console.Write("Inorder after duplicate: ");
tree.PrintInOrder();

Console.WriteLine("Valid AVL: " + tree.IsValid());

// Adding 40 again does not increase the number of nodes
// because the AVL tree does not insert duplicate values.
    }
}
// Part F - Short Answer

// 1. What is the main difference between a Binary Search Tree and an AVL tree?
// A Binary Search Tree keeps values in order, but it may become unbalanced.
// An AVL tree is a self-balancing Binary Search Tree. It uses rotations
// to keep the height of the left and right subtrees balanced.

// 2. What do the balance factors +1, 0, and -1 mean?
// A balance factor of +1 means the left subtree is one level taller.
// A balance factor of 0 means the left and right subtrees have the same height.
// A balance factor of -1 means the right subtree is one level taller.
// All three values are valid for an AVL tree.

// 3. Why is root = Insert(root, value); required?
// Insert may change the root of the tree because an AVL rotation can occur.
// Assigning the returned node back to root makes sure that root points
// to the correct root after insertion and rebalancing.

// 4. Why does inorder traversal of this AVL tree display the values in sorted order?
// Inorder traversal visits the left subtree first, then the current node,
// and then the right subtree. Since an AVL tree follows Binary Search Tree
// ordering, this visits the values from smallest to largest.

// 5. Why is checking only the root's balance factor not enough to determine
// whether the entire tree is AVL balanced?
// Every node in an AVL tree must be balanced, not just the root.
// The root could have a valid balance factor while a node farther down
// the tree is unbalanced. Therefore, all nodes must be checked.