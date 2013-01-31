count <- function(cause = 0) {
  ## Check that "cause" is non-NULL; else throw error
  if(length(cause) == 0){stop("You must supply a cause to get a count.")}
  ## Check that specific "cause" is allowed; else throw error
  causes <- c('shooting','Shooting','blunt force','Blunt Force','asphyxiation','Asphyxiation','stabbing','Stabbing','other','Other','unknown','Unknown')
  if(!cause %in% causes){stop("Invalid cause entered")}
  if(cause == 'shooting' | cause == 'Shooting')(causeRegEx = '[Cc]ause: [Ss]hooting')
  if(cause == 'blunt force' | cause == 'Blunt Force')(causeRegEx = '[Cc]ause: [Bb]lunt [Ff]orce')
  if(cause == 'asphyxiation' | cause == 'Asphyxiation')(causeRegEx = '[Cc]ause: [aA]sphyxiation')
  if(cause == 'stabbing' | cause == 'Stabbing')(causeRegEx = '[Cc]ause: [sS]tabbing')
  if(cause == 'other' | cause == 'Other')(causeRegEx = '[Cc]ause: [oO]ther')
  if(cause == 'unknown' | cause == 'Unknown')(causeRegEx = '[Cc]ause: [uU]nknown')
  ## Read "homicides.txt" data file
  homicides <- readLines("homicides.txt")
  ## Extract causes of death
  i <- grep(causeRegEx,homicides)
  ## Return integer containing count of homicides for that cause
  return(length(i))
}

c('shooting','blunt force','asphyxiation','stabbing','other','unknown')