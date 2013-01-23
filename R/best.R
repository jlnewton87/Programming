best <- function(state, outcome) {
  source("unique.R") #Get unique function
  ## Read outcome data
  outcomes = c('heart attack', 'heart failure', 'pneumonia')
 outcome1 = read.csv("outcome-of-care-measures.csv", 
                    colClasses="character")
  diseaseCol = 0
 outcome1[, 11] <- as.numeric(outcome1[, 11])
 outcome1[, 17] <- as.numeric(outcome1[, 17])
 outcome1[, 23] <- as.numeric(outcome1[, 23])
  if(outcome == 'heart attack')
  {
    diseaseCol = 11
  }
  if(outcome == 'heart failure')
  {
    diseaseCol = 17
  }
  if(outcome == 'pneumonia')
  {
    diseaseCol = 23
  }
 
  ## Check that state and outcome are valid
 if(!state %in% Unique(outcome1[, 7]))
 {
  stop("invalid state") 
 }
  if(!outcome %in% outcomes)
  {
    stop("invalid outcome")
  }
  ## Return hospital name in that state with lowest 30-day death ## rate
  state1 = outcome1[which(outcome1$State == state),]
  hos = state1[which(state1[,diseaseCol] == min(state1[,diseaseCol], na.rm=T)),]
  return(hos$Hospital.Name)
}