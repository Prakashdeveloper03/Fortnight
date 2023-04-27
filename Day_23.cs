using System;
using System.Collections;
using System.Collections.Generic;

class Node {
    public Node left,right;
    public int data;
    public Node(int data) {
        this.data = data;
        left = right = null;
    }
}

class Solution {
	static void levelOrder(Node root) {
        Queue<Node> nodeQueue = new Queue<Node>();
        nodeQueue.Enqueue(root);
        while(nodeQueue.Count > 0) {
            Node actual = nodeQueue.Dequeue();
            Console.Write(actual.data + " ");
            if(actual.left != null)
                nodeQueue.Enqueue(actual.left);
            if(actual.right != null)
                nodeQueue.Enqueue(actual.right);
        }
    }

	static Node insert(Node root, int data) {
        if(root==null)
            return new Node(data);
        else {
            Node cur;
            if(data<=root.data){
                cur=insert(root.left,data);
                root.left=cur;
            }
            else {
                cur=insert(root.right,data);
                root.right=cur;
            }
            return root;
        }
    }

    static void Main(String[] args) {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root,data);            
        }
        levelOrder(root);
    }
}