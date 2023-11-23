# BestBooking (MDS Project)

Dănescu Adela-Gabriela, Dîrțu Ecaterina, Mihailescu Teodor, Pița Bogdan-Ioan

Group 342

## Epic story:

#### Booking.com is overloaded.
#### For the benefit of buyers, we want to help them find the best prices in a new application created by us!

## User stories:

[Trello Link](https://trello.com/invite/mdsbestbooking/ATTI433e5f54374e851e879a648323e985b6BA271634)

[Demo Link]

[Diagram Link](https://drive.google.com/file/d/18PXyDElgSDRy9ncKxb538-3kkto0WEC3/view?usp=sharing)

### MUST: User login with different roles :heavy_check_mark:
#### Acceptance Criteria:
1. **Login Standard:**
   - User can access the application's login page.
   - User can enter valid credentials to log in.
   - Upon successful login, the user is redirected to the homepage.

2. **User Types and Their Responsibilities:**
   - **Unauthenticated User:**
     - Can access and view all pages without login.
   - **Logged-in User:**
     - Can reserve rooms.
     - Can modify/delete their own reservations.
     - Can add reviews to hotels.
     - Can modify/delete their own reviews.
   - **Agent:**
     - Can add hotels.
     - Can modify/delete their own hotels.
     - Can delete/modify any reservation.
   - **Admin:**
     - Can add/modify/delete any entity, including countries.

### MUST: Basic structure (Standard CRUD)  :heavy_check_mark:
#### Acceptance Criteria:
1. **Countries:**
   - Can view a list of countries.
   - Can create a new country.
   - Can update an existing country.
   - Can delete a country.

2. **Hotels:**
   - Can view a list of hotels.
   - Can create a new hotel.
   - Can update an existing hotel.
   - Can delete a hotel.

3. **Reviews:**
   - Can view a list of reviews.
   - Can create a new review.
   - Can update an existing review.
   - Can delete a review.

4. **Rooms:**
   - Can view a list of rooms.
   - Can create a new room.
   - Can update an existing room.
   - Can delete a room.

5. **Reservations:**
   - Can view a list of reservations.
   - Can create a new reservation.
   - Can update an existing reservation.
   - Can delete a reservation.


### MUST: Filtering by hotel description :heavy_check_mark:
#### Acceptance Criteria:
1. **Filtering:**
   - Users can select various criteria for searching hotels.
   - The search results match the selected criteria from hotel descriptions.
   
###SPRINT 1 DEVELOPMENT

### MUST: (3p) Custom search to display available rooms :heavy_check_mark:
#### Acceptance Criteria:
1. **Custom Search:**
   - Users can search for available rooms based on country, period, and number of people.
   - The search results show only rooms available for the specified criteria.

### MUST: (10p) Interface  :heavy_check_mark:
#### Acceptance Criteria:
1. **For Each Basic Unit:**
   - The interface displays relevant information.
   - The user can easily navigate and perform CRUD operations.

### MUST: (2p) Checking the period when creating a reservation :heavy_check_mark:
#### Acceptance Criteria:
1. **Reservation Period Check:**
   - When creating a reservation, the system checks for available slots between check-in and check-out.
   - If no availability, the reservation is not added, and a relevant message is displayed.

### BACKLOG

### SHOULD: (4p) History of previous reservations :heavy_check_mark:
#### Acceptance Criteria:
1. **Viewing Reservation History:**
   - Any user can access a page displaying a list of all their previous reservations.
   - The list includes relevant details such as hotel, period, and status.

### SHOULD: (10p) Transfer of reservations from one user to another
#### Acceptance Criteria:
1. **Offer Creation:**
   - Users can create an offer for transferring a reservation.
   - The offer includes details like hotel, period, and reason for transfer.

2. **CRUD Modification:**
   - CRUD operations are modified to accommodate offer creation and transfer.

3. **Priority Placement:**
   - Offers appear prominently on recommendation and search result pages if they match selected fields.

##### ~ 15/29p
