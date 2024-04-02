using System;
class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }

}

class Solution
{
    public static Node insert(Node head, int data)
    {
        Node newNode = new Node(data);
        if (head == null)
            head = newNode;
        else
        {
            Node temp = head;
            while (temp.next != null)
                temp = temp.next;
            temp.next = newNode;
        }
        return head;
    }
}