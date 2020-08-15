import React from "react";
import ToDoList from "../ToDoList/ToDoList";
import ContactCard from "../ContactCard/ContactCard";

function Main() {
  return (
    <div>
      <ToDoList className="main-content" />
     
     
      <div style={{ display: "flex" }}>
        <ContactCard
          contact={{
            name: "Mr Cat",
            imgUrl:
              "https://images.unsplash.com/photo-1511694009171-3cdddf4484ff",
            phone: "(212) 555-1234",
            email: "mr.whiskaz@catnap.meow",
          }}
        />
        <ContactCard
          contact={{
            name: "Johnson",
            imgUrl:
              "https://cdn.pixabay.com/photo/2017/02/20/18/03/cat-2083492_1280.jpg",
            phone: "(642) 345-5634",
            email: "mrs.bella@catnap.meow",
          }}
        />
        <ContactCard
          contact={{
            name: "Mrs Swathi",
            imgUrl:
              "https://d2c7ipcroan06u.cloudfront.net/wp-content/uploads/2020/04/Cat-representational-image-e1587622908176.jpg",
            phone: "(91) 9045673456",
            email: "iamswathi@catnap.meow",
          }}
        />
        <ContactCard
          contact={{
            name: "Fredrick",
            imgUrl:
              "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/VAN_CAT.png/450px-VAN_CAT.png",
            phone: "(642) 345-5634",
            email: "mrs.bella@catnap.meow",
          }}
        />
      </div>
    </div>
  );
}

export default Main;
