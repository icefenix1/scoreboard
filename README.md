# scoreboard

## Assumption

- The library endpoints will take a Game object.
- The Game object is made up of 2 Team objects.
- The Team object has the following:
  - A Team Name
  - A Team Score
    - The Score defaults to 0
- The start time of the game is the time it is added to the game list ***not*** the actual start time
  - This is for simplicity of ordering.
  - If the actual start time where to be used additional ordering would be needed like Home team Alphabetical.

## Library Requirements

The needs 4 end points.

- Create
- Update
- Finalize
- Get

All endpoints will return a list of Game objects.

### Get Endpoint

#### Get Acceptance criteria

- [x] Can get a empty result when no games in progress.
- [x] Can get a results when games are in progress.

### Create Endpoint

#### Create Acceptance criteria

- [x] Can Pass in an initial game and have it returned.  
- [x] Can Pass in a additional games and have them returned in the correct order.

### Update Endpoint

#### Update Acceptance criteria

- [X] Can Pass in an update to a game when it is the only game in progress and have it returned.  
- [X] Can Pass in a additional update to a game when multiple games are in progress and have them returned in the correct order.
- [X] Can Pass in a additional update to a game that has the same score as another when multiple games are in progress and have them returned in the correct order.

### Finalize Endpoint

#### Finalize Acceptance criteria

- [X] Can Pass in a game to finalize when it is the only game in progress and have empty list returned.
- [X] Can Pass in a game to finalize when multiple games are in progress and have a correctly ordered list returned with the finalized game removed.

## Notes

- I'm not using any Interfaces. This is done for simplicity.
- On a final read of the spec I realized that I miss read it slightly and that a dedicated Summary endpoint is also needed.

## Possible improvements

- Use the display name property of the TestMethod to create test names that more closely tie in to the Acceptance criteria. (This was acting a bit unpredictably so I removed it from the moment)
