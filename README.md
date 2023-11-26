# BestBooking

Made by: **Dănescu Adela-Gabriela, Dîrțu Ecaterina, Mihailescu Teodor, Pița Bogdan-Ioan**

From: **Group 342**

[Trello](https://trello.com/invite/mdsbestbooking/ATTI433e5f54374e851e879a648323e985b6BA271634)

[SMART NFS](https://docs.google.com/document/d/1xByb49eBQnMBz94uNoANoEqbmg6mDLFe02F-84nxcWI/edit)

[User Personas](https://docs.google.com/document/d/1BpeaZb_QCSZPDt4h1vrn6ZAyx8Gbgn7XpYFCS03gpNY/edit)

[Activity Map](https://lucid.app/lucidspark/22f1f6e8-bd7c-44a7-b874-853064e3a1c8/edit?invitationId=inv_2659ac12-0d26-4252-8bbc-a9f0c9408594&page=0_0#)

[Road Map](https://www.canva.com/design/DAF1Qiry4K8/Tsjk5rRTyTlnzvs0VRAZLQ/edit?utm_content=DAF1Qiry4K8&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton)

[Diagram UML](https://drive.google.com/file/d/18PXyDElgSDRy9ncKxb538-3kkto0WEC3/view?usp=sharing)

# Product Vision:

Our project aims to revolutionize the travel booking experience by introducing a dynamic application focused on simplifying the process and providing the best prices for users. 
With a robust user authentication system, the application accommodates to various roles, ensuring a secure login experience and redirecting users to a personalized homepage.

Following the standard CRUD operations, users can interact with entities such as countries, hotels, reviews, rooms, and reservations. 
The application prioritizes efficient searching, allowing users to filter results based on various criteria, with a particular emphasis on matching hotel descriptions for relevance.

Initially, we focus on implementing a custom search feature that enables users to find available rooms based on country, period, and the number of people. 
The user interface is designed for easy navigation, displaying relevant information for each basic unit.

Key features include a thorough check of reservation periods during creation, preventing additions when slots are unavailable. In the future we plan on adding new elements like a detailed history of previous reservations and a transfer feature, allowing users to create offers and prioritize them on recommendation and search result pages.

In summary, our project envisions a transformative travel application that addresses existing platform shortcomings, offering a seamless, user-centric, and feature-rich experience for travelers, agents, and administrators.

# User stories:

## (Done during MDS)

### Login:

   As a user, I want to access the application's login page so that I can enter valid credentials to log in. Upon successful login, I want to be redirected to the homepage.

### User Types and Their Responsibilities:

   **Unauthenticated User:**
   As an unauthenticated user, I want to access and view all pages without login.

   **Logged-in User:**
   As a logged-in user, I want to reserve rooms, modify/delete my own reservations, add reviews to hotels, and modify/delete my own reviews.

   **Agent:**
   As an agent, I want to add hotels, modify/delete my own hotels, and delete/modify any reservation.

   **Admin:**
   As an admin, I want to add/modify/delete any entity, including countries.


### Filtering by Hotel Description:

   As a user, I want to select various criteria for searching hotels so that the search results match the selected criteria from hotel descriptions.

## (First Sprint)

### Custom Search to Display Available Rooms: MUST (3p)

   As a user, I want to search for available rooms based on country, period, and number of people so that the search results show only rooms available for the specified criteria.

### Interface: MUST (10p)

   As a user, for each basic unit, I want the interface to display relevant information so that I can easily navigate and perform CRUD operations.

### Checking the Period When Creating a Reservation: MUST (2p)

   As a user, when creating a reservation, I want the system to check for available slots between check-in and check-out so that if there's no availability, the reservation is not added, and a relevant message is displayed.

## (Current Backlog)

### History of Previous Reservations: SHOULD (4p)

   As a user, I want to access a page displaying a list of all my previous reservations so that the list includes relevant details such as hotel, period, and status.

### Transfer of Reservations from One User to Another: SHOULD (10p)

   **Offer Creation:**
   As a user who gives up a reservation, I want to create an offer for transferring a reservation so that the offer includes details like hotel, period, and reason for transfer.

   **Priority Placement:**
   As a user who makes a reservation, I want the offers to appear prominently on recommendation and search result pages so that, in case they match selected fields, they are easily noticeable.

##### ~ 15/29p


# Acceptance Criteria for two of our user stories:

## User Story 1:

"As a user, I want to search for available rooms based on country, period, and the number of people so that the search results show only rooms available for the specified criteria."

### Acceptance Criteria:

1. Users should be able to access the search feature on the application.
2. The search functionality should allow users to input the desired country, period, and number of people.
3. Search results should only display rooms that match the specified criteria.
4. The displayed results should include detailed information about each available room, such as room type, amenities, and price.
5. If no rooms match the selected criteria, a message should be displayed indicating the unavailability of rooms.
6. The search feature should be responsive, providing quick and accurate results to enhance the user experience.

## User Story 2:

"As a user who gives up a reservation, I want to create an offer for transferring a reservation so that the offer includes details like hotel, period, and reason for transfer."

### Acceptance Criteria:

1. Users should have the option to create an offer for transferring their reservation.
2. The offer creation process should prompt users to specify details such as the hotel, reservation period, and the reason for transfer.
3. Once created, the offer details should be stored and associated with the respective reservation.
4. The system should validate that all required details are provided during the offer creation process.
5. Users should be able to view, edit, and delete their created offers.
6. Offers should be prominently displayed on recommendation and search result pages if they match selected fields, ensuring visibility to potential transferees.
7. If the offer creation process fails (e.g., due to incomplete information), an error message should be displayed, guiding users on how to correct the issue.
