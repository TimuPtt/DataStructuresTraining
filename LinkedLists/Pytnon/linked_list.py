#Реализация свзяных списков

class ListNode(object):
    def __init__(self, data = None):
        self.data = data
        self.next_node = None


class LinkedList(object):
    def __init__(self):
        self.head = None
        self.size = 0

    def __str__(self):
        if self.head != None:
            current = self.head
            out = str(current.data) + '\n'
            while current.next_node != None:
                current = current.next_node
                out += str(current.data) + '\n'
            return str(out)
        else:
            return None 

    def get_size(self):
        return f'{self.size}'
                
        
    def push_front(self, data):
        self.size += 1
        new_node = ListNode(data)
        if self.head == None:
            self.head = new_node
        else:
            new_node.next_node = self.head
            self.head = new_node

    def push_back(self, data):
        self.size += 1
        new_node = ListNode(data)
        if self.head == None:
            self.head = new_node
        else:
            current = self.head
            while current.next_node != None:
                current = current.next_node
            current.next_node = new_node            

    def pop_front(self):
        if self.head != None:
            self.size -= 1
            self.head = self.head.next_node

    def pop_back(self):
        if self.head != None:
            self.size -= 1
            current = self.head           
            while current.next_node.next_node != None:
                current = current.next_node
            current.next_node = None 

    def front(self):
        if self.head != 0:
            return self.head.data

    def back(self):
        if self.head != None:
            current = self.head           
            while current.next_node != None:
                current = current.next_node
            return current.data

    def empty(self):
        if self.head == None:
            return True
        else:
            return False

    def value_at(self, index):
        if index == 0:
            return self.head.data
        else: 
            counter = 0
            current = self.head
            while counter < index:
                counter += 1
                current = current.next_node
        return current.data

    #TODO push_back pop_back front back insert earse reverse remove value

if __name__ == "__main__":
    list = LinkedList()
    list.push_front(3)
    list.push_front(2)
    list.push_front(1)

    size = list.get_size()
    print(size)
    print('\n')
    print(list)

    print(str(list.value_at(2)))

    print('\n')
    list.pop_front()

    print(list)

    print(str(list.value_at(0)))