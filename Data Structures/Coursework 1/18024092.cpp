//18024092 Jessica Clara Fealy
//Data Structures And Algorithms With Object Oriented Programming Coursework 1

#include <string>
#include<iostream>

class Node
{
public:
	Node(int value, Node* nextptr = NULL, Node* prevptr = NULL, int currentpriority = 0) {
		this->value = value;
		next = nextptr;
		prev = prevptr;
		this->priority = currentpriority;
	}

	int getVal(void) { return value; }
	Node* getNext(void) { return next; }
	Node* getPrev(void) { return prev; }
	void setVal(int value) { Node::value = value; }
	void setPrev(Node* prevptr) { prev = prevptr; }
	void setNext(Node* nextptr) { next = nextptr; }
	int getPriority(void) { return priority; }
	void setPriority(int priority) { Node::priority = priority; }

private:
	Node* next;
	Node* prev;
	int priority;
	int value;
};

class Stack
{
public:
	Stack(void) {
		top = nullptr;
	}

	~Stack(void) {
		while (this->top != nullptr)
		{
			this->Pop();
		}
	}

	void Push(int value) {
		Node* tmp = new Node(value, this->top);
		this->top = tmp;
	}

	Node* NodePop(void) {
		Node* tmp = top->getNext();
		return tmp;
	}

	int Pop(void) {
		if (this->top == nullptr)
		{
			throw "Stack Empty";
		}
		int value = top->getVal();
		top = NodePop();
		return value;
	}

	void displayStack() {
		Node* tmp = this->top;
		while (tmp != nullptr)
		{
			std::cout << tmp->getVal() << std::endl;
			tmp = tmp->getNext();
		}
	}

private:

	Node* top;
};

class Queue
{
public:
	Queue(void){
		back = nullptr;
		front = nullptr;
	}

	~Queue(void) {
		while (front != nullptr) {
			delete NodeDequeue();
		}
	}

	void Enqueue(int i, int priority = 0) {
		Node* tmp = new Node(i, back, nullptr, priority);
		back = tmp;
		if (front == nullptr)
		{
			front = back;
		}
		else {
			tmp = back->getNext();
			tmp->setPrev(back);
		}
	}

	int Dequeue(void) {
		Node* tmp = NodeDequeue();
		int returnVal = 0;
		if (tmp != nullptr)
		{
			returnVal = tmp->getVal();
		}
		else
			throw std::string("Queue Empty");
		if (front == nullptr)
		{
			back = front;
		}
		return returnVal;
	}

	void Print(std::string order) {
		std::cout << "Printing queue [" << order << "]" << std::endl;
		Node* temp = nullptr;
		if (front == nullptr && back == nullptr)
		{
			std::cout << "Queue Empty" << std::endl;
		}
		else
		{
			if (order == "forward")
			{
				temp = front;
				while (temp != nullptr)
				{
					std::cout << temp->getVal() << ", ";
					std::cout << temp->getPriority() << std::endl;
					temp = temp->getPrev();
				}
			}
			else
			{
				temp = back;
				while (temp != nullptr)
				{
					std::cout << temp->getVal() << ", ";
					std::cout << temp->getPriority() << std::endl;
					temp = temp->getNext();
				}
			}

			std::cout << std::endl;
		}

	}

protected:

	Node* back;
	Node* front;

private:

	virtual Node* NodeDequeue(void){
		return nullptr;
	}
};


class Scheduler : public Queue
{
private:
	int time = 0;


	Node* NodeDequeue(void) {

		Node* maxPtr = ptrToRemove();
		int val = maxPtr->getVal();
		Node* prevMax = maxPtr->getPrev();
		Node* nextMax = maxPtr->getNext();
		int priority = maxPtr->getPriority();
		if (maxPtr == back && maxPtr == front)
		{
			back = maxPtr->getNext();
			front = maxPtr->getPrev();
		}
		else {
			if (maxPtr == back)
			{
				back = maxPtr->getNext();
				nextMax->setPrev(prevMax);
			}
			else if (front == maxPtr) {
				front = maxPtr->getPrev();
				prevMax->setNext(nextMax);
			}
			else
			{
				prevMax->setNext(nextMax);
				nextMax->setPrev(prevMax);
			}
		}
		NodeAging(priority);
		return maxPtr;
	}

	Node* ptrToRemove()
	{
		Node* maxPtr = front; //Sets the highest priority as the front of the queues
		Node* temp = front; //Create a new Node to iteratre through the queue
		int maxPriority = 0;
		int currentPriority = 0;
		while (temp != nullptr)
		{
			currentPriority = temp->getPriority();
			if (currentPriority > maxPriority)
			{
				maxPriority = currentPriority;
				maxPtr = temp;
			}
			temp = temp->getPrev();
		}
		return maxPtr;
	}

	void NodeAging(int highestPriority) {
		Node* temp = front;
		time++; //iterates the time counter to determine when to increase the other nodes
		if (time == 2) //Every time 2 nodes are removed every other node have their priority upped
		{
			while (temp != nullptr) //Ensure temp is referering to a position in the queue
			{
				int currentPriority = temp->getPriority(); //Gets the priority of of the current node in the queue
				if (currentPriority < highestPriority) //Ensures that the highest priroity isnt being changed
				{
					temp->setPriority(currentPriority + 1); //Increases the current priority by 1
				}
				temp = temp->getPrev(); //Sets the temp pointer to the next item in the queue
			}
	
			time = 0; //Resets the time value 
		}
 
	}

};


int main()
{
	Stack my_stack;
	my_stack.Push(10);
	my_stack.Push(20);

	my_stack.displayStack();

	my_stack.Pop();
	my_stack.Pop();
	my_stack.displayStack();

	Scheduler numbers;
	numbers.Enqueue(1, 5);
	numbers.Enqueue(2, 4);
	numbers.Enqueue(3, 5);
	numbers.Enqueue(4, 4);
	numbers.Enqueue(5, 4);
	numbers.Enqueue(6, 4);
	numbers.Enqueue(7, 5);
	numbers.Enqueue(8, 5);
	numbers.Enqueue(9, 3);
	numbers.Enqueue(10, 3);

	numbers.Print("forward");
	numbers.Print("backwards");

for (int i = 0; i < 11; i++)
{
	std::cout << "Dequeue = " << numbers.Dequeue() << std::endl;
	numbers.Print("forward");
}
	try
	{
		for (int i = 0; i < 10; i++)
		{
			std::cout << "Dequeue = " << numbers.Dequeue() << std::endl;
			numbers.Print("forward");
		}
	}
	catch (std::string msg)
	{
		std::cout << std::endl << msg << std::endl;
	}
	system("pause");
	return 0;
}